﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using SIC.Modelo;

namespace SIC.DAO
{
    public class SellerDAO
    {
        //DataTable
        DataTable dtSeller;
        DataTable dtSellerReprocessamento;

        //CONEXÃO SQLSERVER
        SqlConnection conexaoFront;

        OracleDataAdapter daSellerAD;
        SqlDataAdapter daSellerAtiva;

        //CONEXÃO ORACLE
        //Conexão - ADPRD
        OracleConnection conexaoADPRD;

        //Boolean
        Boolean sellerAtivada = false;

        //CMD
        //SqlCommand cmdSellerFront;
        OracleCommand cmdSellerAD;

        //Begin
        OracleTransaction transaction = null;
        //SqlTransaction transactionFront = null;

        public DataTable ListagemSellerFront(int IdSeller)
        {
            try
            {
                conexaoFront = Conexao.ConectarSL();
                conexaoFront.Open();

                daSellerAtiva = new SqlDataAdapter();
                daSellerAtiva.SelectCommand = new SqlCommand();
                daSellerAtiva.SelectCommand.Connection = conexaoFront;

                daSellerAtiva.SelectCommand.CommandText = "SELECT 	CB.idlojista " +
                                                                    ", CB.Nome" +
		                                                            ", CB.FlagAtiva as 'FlagAtiva_CasasBahia'   " +
		                                                            ", PF.FlagAtiva as 'FlagAtiva_PontoFrio'    " +
		                                                            ", E.FlagAtiva as 'FlagAtiva_Extra'        " +
                                                            "  FROM db_prd_ExtracaoParceiro..Lojista_Pontofrio PF, db_prd_ExtracaoParceiro..Lojista_CasasBahia CB, db_prd_ExtracaoParceiro..Lojista_Extra E " +
                                                                        " WHERE   CB.idlojista = PF.idlojista " +
                                                                                " AND CB.idlojista = E.idlojista " +                                                           
                                                                                " AND CB.idlojista in (" + IdSeller + ")";

                dtSeller = new DataTable();
                daSellerAtiva.Fill(dtSeller);

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Não otivemos resposta para consulta da loja pelo banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta para consulta da loja pelo banco de dados" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoFront.Close();
            }

            return dtSeller;
        }

        public DataTable ListagemSellerADPRD(int idLogista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();

            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;
            
            try
            {
                //conexaoADPRD.Open();

                daSellerAD = new OracleDataAdapter();
                daSellerAD.SelectCommand = new OracleCommand();
                daSellerAD.SelectCommand.Connection = conexaoADPRD;

                daSellerAD.SelectCommand.CommandText = "SELECT STORE_QUALIFIER_ID AS IdLojista" +
                                                                ", STORE_QUALIFIER_NAME as Lojista" +
                                                                ", ACTIVE as Ativo" +
                                                                ", ID_CATEGORY_SELLER AS Categoria " +
                                                        "FROM AC_ADMIN.ecad_store_qualifier where store_qualifier_id in(" + idLogista + ")"; //in(116303)";

                dtSeller = new DataTable();
                daSellerAD.Fill(dtSeller);                

            }
            catch(OracleException  e)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoADPRD.Close();
            }

            return dtSeller;
        }

        public DataTable ListagemSellerReprocessamento(int idLogista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();

            conexaoADPRD = Conexao.ConectarAD(loginModelo);
            //connection.ConnectionTimeout = 30;

            try
            {
                //conexaoADPRD.Open();

                daSellerAD = new OracleDataAdapter();
                daSellerAD.SelectCommand = new OracleCommand();
                daSellerAD.SelectCommand.Connection = conexaoADPRD;

                daSellerAD.SelectCommand.CommandText = "SELECT * FROM AC_ADMIN.ECMA_SKU_STORE_STATUS " +
                                                           " WHERE STORE_QUALIFIER_ID in(" + idLogista + ")";

                dtSellerReprocessamento = new DataTable();
                daSellerAD.Fill(dtSellerReprocessamento);

            }
            catch (OracleException e)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não otivemos resposta do banco de dados." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoADPRD.Close();
            }

            return dtSellerReprocessamento;
        }

        //Ativar Loja passo 1
        public Boolean AtivarSellerAD(int idLojista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();

            try
            {
                conexaoADPRD = Conexao.ConectarAD(loginModelo);
                //conexaoADPRD.Open();
                transaction = conexaoADPRD.BeginTransaction(IsolationLevel.Serializable);

                cmdSellerAD = new OracleCommand();
                cmdSellerAD.Connection = conexaoADPRD;
                cmdSellerAD.CommandText = " UPDATE AC_ADMIN.ECAD_STORE_QUALIFIER " +
                                             " SET ACTIVE = 'Y', " +
                                             " COMERCIAL_STATUS = '1' WHERE STORE_QUALIFIER_ID IN (" + idLojista + ")";
                string sCommand = cmdSellerAD.ExecuteReader().ToString();

                transaction.Commit();
                
                sellerAtivada = true;
            }
            catch (Exception)
            {

                throw;
            }

            return sellerAtivada;
        }

        //Passo 2
        //A pesquisa é no FRONT porém a atualização é no ADPRD
        public Boolean AtivarSellerFRONT(int idLojista, LoginModelo loginModelo)
        {
            conexaoFront = new SqlConnection();
            try
            {
                conexaoADPRD = Conexao.ConectarAD(loginModelo);
                //conexaoADPRD.ConnectionTimeout = 20;
                //conexaoADPRD.Open();
                transaction = conexaoADPRD.BeginTransaction(IsolationLevel.Serializable);

                cmdSellerAD = new OracleCommand();
                cmdSellerAD.Connection = conexaoADPRD;
                cmdSellerAD.CommandText = " UPDATE AC_ADMIN.ECMA_STORE_QUALIFIER_SITE " +
                                               " SET UPD_DATE = sysdate " +
                                               " WHERE STORE_QUALIFIER_ID IN (" + idLojista + ")";
                string sCommand = cmdSellerAD.ExecuteReader().ToString();
                
                

                transaction.Commit();

                sellerAtivada = true;
            }
            catch (OracleException ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro na ativação da loja." + ex.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //sellerAtivada = false;
            }
            catch(Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro na ativação da loja." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sellerAtivada = false;
            }

            return sellerAtivada;
        }

        public Boolean ReprocessarLoja(int idLojista, LoginModelo loginModelo)
        {
            conexaoADPRD = new OracleConnection();
            try
            {
                //string s = ;
                conexaoADPRD = Conexao.ConectarAD(loginModelo);
                //conexaoADPRD.Open();
                
                transaction = conexaoADPRD.BeginTransaction(IsolationLevel.ReadCommitted);

                cmdSellerAD = new OracleCommand();
                cmdSellerAD.Connection = conexaoADPRD;
                cmdSellerAD.CommandTimeout = 6000;
                cmdSellerAD.CommandType = CommandType.Text;
                cmdSellerAD.CommandText = " INSERT INTO FI.EVENTS_STREAMS(ID, OPERATION, CONTENT, CREATED_AT) " +
                                            " SELECT FI.SEQ_FI_EVENTS.NEXTVAL, 'SKU_STATUS', " + "'{" + "\"shopId\"" + String.Concat(":") + String.Concat("\"") + String.Concat("'") +  "|| store_qualifier_id ||" + "'" + String.Concat("\",") +
                                            "\"skuId\"" + String.Concat(":") + String.Concat("\"") + String.Concat("'") + "|| sku_id ||" + "'" + String.Concat("\",") +
                                            "\"siteId\"" + String.Concat(":") + String.Concat("\"") + String.Concat("'") + "|| site_id ||" + "'\"}" + String.Concat("\',") +
                                            " SYSDATE FROM AC_ADMIN.ECMA_SKU_STORE_STATUS " +
                                                " WHERE STORE_QUALIFIER_ID IN (" + idLojista + ")" +
                                                    "AND STORE_ID = 'NCMP' " +
                                                    "AND STORE_QUALIFIER_ID not in (select store_qualifier_id from AC_ADMIN.ECMA_SHOP_SHOP_GROUP) " +
                                                    "AND status = 'Y' and SITE_ID in ('2', '3', '4')";
                
                string sReader = cmdSellerAD.ExecuteNonQuery().ToString();
                

                transaction.Commit();

                sellerAtivada = true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro " + ex.Message, "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sellerAtivada;
        }


    }
}