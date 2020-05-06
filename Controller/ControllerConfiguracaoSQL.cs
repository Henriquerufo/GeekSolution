﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ControllerConfiguracaoSQL
    {
        string parametrosSQL = string.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};",
            Properties.SettingsSQL.Default.ServidorBD,
            Properties.SettingsSQL.Default.NomeBD,
            Properties.SettingsSQL.Default.IDBD,
            Properties.SettingsSQL.Default.SenhaBD);

        SqlConnection conexao = null;

        public SqlConnection Conectar()
        {
            try
            {
                conexao = new SqlConnection(parametrosSQL);
                conexao.Open();
                return conexao;
            }
            catch
            {
                throw new Exception();
            }
        }
        public bool Conectar(ModelConfiguracaoSQL modelConfiguracaoSQL)
        {
            try
            {
                Properties.SettingsSQL.Default.ServidorBD = modelConfiguracaoSQL.ServidorBD;
                Properties.SettingsSQL.Default.NomeBD = modelConfiguracaoSQL.NomeBD;
                Properties.SettingsSQL.Default.IDBD = modelConfiguracaoSQL.IDBD;
                Properties.SettingsSQL.Default.SenhaBD = modelConfiguracaoSQL.SenhaBD;
                Properties.SettingsSQL.Default.Save();

                return true;
            }
            catch
            {

                throw new Exception();
            }
        }
        public ModelConfiguracaoSQL Carregar()
        {
            ModelConfiguracaoSQL modelConfiguracaoSQL = new ModelConfiguracaoSQL();
            modelConfiguracaoSQL.ServidorBD = Properties.SettingsSQL.Default.ServidorBD;
            modelConfiguracaoSQL.NomeBD = Properties.SettingsSQL.Default.NomeBD;
            modelConfiguracaoSQL.IDBD = Properties.SettingsSQL.Default.IDBD;
            modelConfiguracaoSQL.SenhaBD = Properties.SettingsSQL.Default.SenhaBD;

            return modelConfiguracaoSQL;
        }
    }
}