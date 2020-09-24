using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // tem que add*
using System.Data.SqlClient; // too
using System.Windows.Forms; // too
using System.IO;//tooo
using System.Drawing.Imaging;//tooo
using System.Drawing;//tooo
using System.Security.Cryptography;//too tooo

namespace Hospital_D.FilipinoSmith
{
    class Banco
    {
        const string strConexao = "Data Source=.\\SQLEXPRESS; Initial Catalog=DomFilipinoSmithData; Integrated Security = SSPI";

        public static SqlCommand getCmd()
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conexao.Open();
                cmd.Connection = conexao;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }
            return cmd;
        }

        public static DataTable Select_AllPaciente()
        {
            SqlCommand cmd = getCmd();
            DataTable datatable = null;
            try
            {
                //cmd.CommandText = "SELECT id, nome, sexo, cidade FROM Cad";
                cmd.CommandText = "SELECT idPaciente, NomePaciente, Situação FROM PACIENTE.Paciente";
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                datatable = new DataTable();
                data.Fill(datatable);
                cmd.Connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return datatable;
        }

        public static DataTable Select_Estoque()
        {
            SqlCommand cmd = getCmd();
            DataTable datatable = null;
            try
            {
                cmd.CommandText = "SELECT idEstoque, NomeEstoq, Qnt_Item FROM ITENS.Estoque";
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                datatable = new DataTable();
                data.Fill(datatable);
                cmd.Connection.Close();              
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return datatable;
        }

        public static void Select_CadSuccess(PictureBox img, string tipo)
        {
            SqlConnection conect = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conect.Open();
                cmd.Connection = conect;
                if (tipo == "paciente")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT TOP 1 idFicha from PACIENTE.Paciente order by idPaciente DESC";
                    int id = (int)cmd.ExecuteScalar();
                    cmd.CommandText = "SELECT Imagem_Pac FROM PACIENTE.Ficha where idFicha =" + id;
                }
                else if(tipo == "funcionario")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT TOP 1 idFuncionario from FUNCIONARIO.funcionario order by idFuncionario DESC";
                    int id = (int)cmd.ExecuteScalar();
                    cmd.CommandText = "SELECT Img_Fun FROM FUNCIONARIO.funcionario where idFuncionario =" + id;
                }
                SqlDataReader tabela = cmd.ExecuteReader();
                if (tabela.Read())
                {
                    byte[] bdebyte = new Byte[0];
                    bdebyte = (Byte[])tabela.GetSqlBinary(0);
                    MemoryStream ms_data = new MemoryStream(bdebyte);
                    img.Image = Image.FromStream(ms_data);
                    img.SizeMode = PictureBoxSizeMode.Zoom; // Mundando tamanho img
                }
                cmd.Connection.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message + "\n" + cmd.CommandText);
            }
            finally
            {
                conect.Close();
            }
        }

        public static void Select_dadosCadSucess(Label nome, string tipo)
        {
            SqlConnection conect = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conect.Open();
                cmd.Connection = conect;
                if (tipo == "paciente")
                {
                    cmd.CommandText = "SELECT TOP 1 idPaciente from PACIENTE.Paciente order by idPaciente DESC";
                    int id = (int)cmd.ExecuteScalar();
                    string seleciona = "SELECT NomePaciente, RG_Pac, CPF_Pac FROM PACIENTE.Paciente "+
                                        "INNER JOIN PACIENTE.ficha ON "+
                                        "paciente.idFicha = ficha.idFicha "+
                                        "where idPaciente=" + id;
                    SqlCommand com = new SqlCommand(seleciona, conect);
                    SqlDataReader read = com.ExecuteReader();
                    while (read.Read())
                    {
                        nome.Text = (read["NomePaciente"].ToString());
                    }
                    read.Close();
                }
                else if (tipo == "funcionario")
                {
                    cmd.CommandText = "SELECT TOP 1 idFuncionario from FUNCIONARIO.funcionario order by idFuncionario DESC";
                    int id = (int)cmd.ExecuteScalar();
                    string seleciona = "SELECT Nome_Fun, RG_Fun, CPF_Fun FROM FUNCIONARIO.funcionario where idFuncionario=" + id;
                    SqlCommand com = new SqlCommand(seleciona, conect);
                    SqlDataReader read = com.ExecuteReader();
                    while (read.Read())
                    {
                        nome.Text = (read["Nome_Fun"].ToString());
                    }
                    read.Close();
                }
                cmd.Connection.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message + "\n" + cmd.CommandText);
            }
            finally
            {
                conect.Close();
            }
        }

        public static void Insert_Paciente(string nome, string necess, 
                                           string conv, string situ)
        {
            SqlCommand cmd = getCmd();
            try
            {
                cmd.CommandText = "INSERT INTO PACIENTE.Paciente (NomePaciente, Necessidade, Convenio, Situação)"+
                                  "VALUES (@Nome, @Ness, @Conv, @Situ)";
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.Add(new SqlParameter("@idPaciente", id));
                cmd.Parameters.Add(new SqlParameter("@Nome", nome));
                cmd.Parameters.Add(new SqlParameter("@Ness", necess));
                cmd.Parameters.Add(new SqlParameter("@Conv", conv));
                cmd.Parameters.Add(new SqlParameter("@Situ", situ));
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public static void Insert_Ficha(string telefone1,
                                        string telefone2, string email,
                                        string sexo, string rgPac,
                                        string cpfPac, string naturalidadePac,
                                        string nascimentoPac, string nomePaiPac,
                                        string nomeMaePac, string estadoCivilPac,
                                        string estadoPac, string cidadePac,
                                        string enderecoPac, string numeroPac,
                                        string bairroPac, string complementoPac,
                                        string observacaoPac, string caminho_imagem)
        {
            SqlCommand cmd = getCmd();
            try
            {        
                cmd.CommandText = "INSERT PACIENTE.ficha (Imagem_Pac) SELECT * FROM OPENROWSET(BULK '"
                                   + caminho_imagem + "', SINGLE_BLOB) a";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT TOP 1 idFicha from PACIENTE.Ficha order by idFicha DESC";
                int id = (int)cmd.ExecuteScalar();
                cmd.CommandText = "UPDATE PACIENTE.Ficha SET "+
                                  "TelContato=@tell1,TelPessoal=@tell2,Email=@Email,Sexo=@sexo,RG_Pac=@rg,CPF_Pac=@cpf,"+
                                  "Naturalidade=@natu,"+
                                  "dataNascimento=@nascimento,NomePai=@npai,NomeMae=@nmae,EstadoCivil=@estcivil,"+
                                  "Estado=@estado,Cidade=@cidade,Endereco=@ender,"+
                                  "Numero=@num,Bairro=@bairro,Complemento=@comple,obs=@obs "+ // espaço <<<
                                  "WHERE idFicha ="+id;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@Tell1", telefone1));
                cmd.Parameters.Add(new SqlParameter("@Tell2", telefone2));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
                cmd.Parameters.Add(new SqlParameter("@rg", rgPac));
                cmd.Parameters.Add(new SqlParameter("@cpf", cpfPac));
                cmd.Parameters.Add(new SqlParameter("@natu", naturalidadePac));
                cmd.Parameters.Add(new SqlParameter("@nascimento", nascimentoPac));
                cmd.Parameters.Add(new SqlParameter("@npai", nomePaiPac));
                cmd.Parameters.Add(new SqlParameter("@nmae", nomeMaePac));
                cmd.Parameters.Add(new SqlParameter("@estcivil", estadoCivilPac));
                cmd.Parameters.Add(new SqlParameter("@estado", estadoPac));
                cmd.Parameters.Add(new SqlParameter("@cidade", cidadePac));
                cmd.Parameters.Add(new SqlParameter("@ender", enderecoPac));
                cmd.Parameters.Add(new SqlParameter("@num", numeroPac));
                cmd.Parameters.Add(new SqlParameter("@bairro", bairroPac));
                cmd.Parameters.Add(new SqlParameter("@comple", complementoPac));
                cmd.Parameters.Add(new SqlParameter("@obs", observacaoPac));
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT TOP 1 idPaciente from PACIENTE.Paciente order by idPaciente DESC";
                int idPac = (int)cmd.ExecuteScalar();
                cmd.CommandText = "UPDATE PACIENTE.Paciente SET idFicha=" + id + " WHERE idPaciente= " + idPac.ToString();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public static void Insert_Funcionarios(string nomefun, string rgfun, 
                                               string cpffun, string statusfun,
                                               string funcao, string caminho_imagem)
        {
            SqlCommand cmd = getCmd();
            try
            {
                cmd.CommandText = "INSERT FUNCIONARIO.funcionario (Img_Fun) SELECT * FROM OPENROWSET(BULK '"
                + caminho_imagem + "', SINGLE_BLOB) a";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT TOP 1 idFuncionario FROM FUNCIONARIO.funcionario order by idFuncionario DESC";
                int id = (int)cmd.ExecuteScalar();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@nomefun", nomefun));
                cmd.Parameters.Add(new SqlParameter("@rgfun", rgfun));
                cmd.Parameters.Add(new SqlParameter("@cpffun", cpffun));
                cmd.Parameters.Add(new SqlParameter("@statusfun", statusfun));
                cmd.CommandText = "UPDATE FUNCIONARIO.funcionario SET " +
                                  "Nome_Fun=@nomefun, RG_Fun=@rgfun, CPF_Fun=@cpffun, StatusFun=@statusfun "+
                                  "WHERE idFuncionario="+id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public static void Insert_Medico(string Especializacao, string Horario)
        {
            SqlCommand cmd = getCmd();
            cmd.CommandText = "SELECT TOP 1 idFuncionario FROM FUNCIONARIO.funcionario order by idFuncionario DESC";
            int id = (int)cmd.ExecuteScalar();
            cmd.CommandText = "INSERT INTO FUNCIONARIO.Medico(idConsulta, idExame, IdCirurgia, Especializacao, Horario_Med) VALUES (" +
                                      "NULL," +
                                      "NULL," +
                                      "NULL," +
                                      "@esp," +
                                      "@hor)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@esp", Especializacao));
            cmd.Parameters.Add(new SqlParameter("@hor", Horario));
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT TOP 1 idMedicos FROM FUNCIONARIO.Medico order by idMedicos DESC";
            int idmedico = (int)cmd.ExecuteScalar();
            cmd.Parameters.Add(new SqlParameter("@idmedico", idmedico));
            cmd.CommandText = "UPDATE FUNCIONARIO.Funcionario SET idMedicos=@idmedico WHERE idFuncionario=" + id;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Insert_Enfermeiro(string status)
        {
            SqlCommand cmd = getCmd();
            cmd.CommandText = "SELECT TOP 1 idFuncionario FROM FUNCIONARIO.funcionario order by idFuncionario DESC";
            int id = (int)cmd.ExecuteScalar();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@status", status));
            cmd.CommandText = "INSERT INTO FUNCIONARIO.Enfermeiro (idLeitos,iduti,status) VALUES " +
                "(NULL,NULL,@status)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT TOP 1 idEnfer FROM FUNCIONARIO.Enfermeiro order by idEnfer DESC";
            int idenfer = (int)cmd.ExecuteScalar();
            cmd.Parameters.Add(new SqlParameter("@idenfer", idenfer));
            cmd.CommandText = "UPDATE FUNCIONARIO.Funcionario SET idEnfer=@idEnfer WHERE idFuncionario=" + id;
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Insert_Usuario(string idfun, string usuario, string senha)
        {
            var hash = new Hash(SHA512.Create());
            SqlCommand cmd = getCmd();
            try
            {
                cmd.CommandText = "INSERT INTO ENTRAR.Login (IdFuncionario, Usuario, Senha)" +
                                  "VALUES (@idfun, @User, @Senha)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@idfun", idfun));
                cmd.Parameters.Add(new SqlParameter("@User", usuario));
                cmd.Parameters.Add(new SqlParameter("@Senha", hash.CriptografarSenha(senha)));
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public static bool Verificar_Login_Senha(ref bool verific, string usuario, string senha)
        {
            var hash = new Hash(SHA512.Create());
            string passworduser = "";
            SqlCommand cmd = getCmd();
            SqlConnection conect = new SqlConnection(strConexao);
            try
            {
                conect.Open();
                cmd.Connection = conect;
                cmd.CommandText = "select COUNT(*) From ENTRAR.Login where usuario = @usuario";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@usuario", usuario));
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    cmd.CommandText = "SELECT Senha FROM ENTRAR.Login where usuario=@user";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@user", usuario));
                    passworduser = (string)cmd.ExecuteScalar();
                    if (hash.VerificarSenha(senha, passworduser))
                    {
                        verific = true;
                    }
                    else
                        verific = false;
                }
                else
                    verific = false;
                cmd.Connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return verific;
        }

        public static bool Verifica_user(ref bool okuser, string user)
        {
            SqlCommand cmd = getCmd();
            SqlConnection conect = new SqlConnection(strConexao);
            try
            {
                conect.Open();
                cmd.Connection = conect;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@usuario", user));
                cmd.CommandText = "select COUNT(*) From ENTRAR.Login where usuario = @usuario";
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                    okuser = false;
                else
                    okuser = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return okuser;
        }

        public static bool Verifica_userId(ref bool okuser, string idfun)
        {
            SqlCommand cmd = getCmd();
            SqlConnection conect = new SqlConnection(strConexao);
            try
            {
                conect.Open();
                cmd.Connection = conect;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@idfun", idfun));
                cmd.CommandText = "select COUNT(*) From FUNCIONARIO.Funcionario where idFuncionario = @idfun";
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@idfunlogin", idfun));
                    cmd.CommandText = "select COUNT(*) From Entrar.Login where idFuncionario = @idfunlogin";
                    int count2 = (int)cmd.ExecuteScalar();
                    if (count2 > 0)
                        okuser = false;
                    else
                        okuser = true;
                }
                else
                    okuser = false;
                conect.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return okuser;
        }

        public static bool Pesquisa_Paciente(string bus_id , TextBox nomepac, TextBox situ, TextBox leito,
                                             TextBox tell, TextBox cell, PictureBox img ,ref bool ok)
        {
            SqlConnection conect = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conect.Open();
                cmd.Connection = conect;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", bus_id));
                bool okid = false;
                if (bus_id.Length > 7)
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM PACIENTE.ficha " +
                                      "WHERE ficha.CPF_Pac = @id";
                }
                else
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM PACIENTE.paciente " +
                                      "WHERE paciente.idPaciente = @id";
                    okid = true;
                }
                int id = (int)cmd.ExecuteScalar();
                string seleciona;
                if(id > 0)
                {
                    if (okid)
                        cmd.CommandText ="SELECT COUNT(*) FROM LOCAIS.leito "+
                                         "WHERE leito.idPaciente = @id";
                    else
                        cmd.CommandText = "SELECT COUNT(*) FROM PACIENTE.Paciente " +
                                          "INNER JOIN PACIENTE.ficha ON " +
                                          "paciente.idFicha = ficha.idFicha " +
                                          "INNER JOIN LOCAIS.Leito ON " +
                                          "paciente.idPaciente = leito.idPaciente " +
                                          "WHERE ficha.CPF_Pac = @id";
                    int count = (int)cmd.ExecuteScalar();
                    if(count > 0)
                    {
                        seleciona = "SELECT Paciente.NomePaciente, Paciente.Situação," +
                                    "ficha.TelContato, ficha.TelPessoal,leito.idLeitos " +
                                    "FROM PACIENTE.Paciente " +
                                    "INNER JOIN PACIENTE.ficha ON " +
                                    "Paciente.idFicha = ficha.idFicha " +
                                    "INNER JOIN LOCAIS.Leito ON " +
                                    "Paciente.idPaciente = Leito.idPaciente " +
                                    "WHERE ficha.CPF_Pac = '"+bus_id+"'" + // AQUIIIIIIIIIIII
                                    "OR paciente.idPaciente = " +Int64.Parse(bus_id); // AQUIIIII
                                    SqlCommand com = new SqlCommand(seleciona, conect);
                                    SqlDataReader read = com.ExecuteReader();
                                    while (read.Read())
                                    {
                                        nomepac.Text = (read["NomePaciente"].ToString());
                                        situ.Text = (read["Situação"].ToString());
                                        leito.Text = (read["idLeitos"].ToString());
                                        tell.Text = (read["TelContato"].ToString());
                                        cell.Text = (read["TelPessoal"].ToString());
                                    }
                                    read.Close();
                    }
                    else
                    {
                        seleciona = "SELECT Paciente.NomePaciente, Paciente.Situação," +
                                    "ficha.TelContato, ficha.TelPessoal " +
                                    "FROM PACIENTE.Paciente " +
                                    "INNER JOIN PACIENTE.ficha ON " +
                                    "Paciente.idFicha = ficha.idFicha " +
                                    "WHERE paciente.idPaciente= " +Int64.Parse(bus_id) +
                                    "OR ficha.CPF_Pac= '"+bus_id+"'";
                                    SqlCommand com = new SqlCommand(seleciona, conect);
                                    SqlDataReader read = com.ExecuteReader();
                                    while (read.Read())
                                    {
                                        nomepac.Text = (read["NomePaciente"].ToString());
                                        situ.Text = (read["Situação"].ToString());
                                        tell.Text = (read["TelContato"].ToString());
                                        cell.Text = (read["TelPessoal"].ToString());
                                    }
                                    leito.Text = "--";
                                    read.Close();
                    }
                    if (okid)
                        cmd.CommandText = "SELECT ficha.Imagem_Pac FROM PACIENTE.Paciente " +
                        "INNER JOIN PACIENTE.ficha ON PACIENTE.idFicha = ficha.idFicha " +
                        "WHERE paciente.idPaciente=@id";
                    else
                        cmd.CommandText = "SELECT ficha.Imagem_Pac FROM PACIENTE.Paciente " +
                       "INNER JOIN PACIENTE.ficha ON PACIENTE.idFicha = ficha.idFicha " +
                       "WHERE ficha.CPF_Pac=@id";
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader tabela = cmd.ExecuteReader();
                    if (tabela.Read())
                    {
                        byte[] bdebyte = new Byte[0];
                        bdebyte = (Byte[])tabela.GetSqlBinary(0);
                        MemoryStream ms_data = new MemoryStream(bdebyte);
                        img.Image = Image.FromStream(ms_data);
                        img.SizeMode = PictureBoxSizeMode.Zoom; // Mundando tamanho img
                    }
                    cmd.Connection.Close();
                }
                else
                {
                    ok = false;
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message + "\n" + cmd.CommandText);
            }
            finally
            {
                conect.Close();
            }
            return ok;
        }

        public static bool Select_All_Dados_Paciente(string bus_id,TextBox nome, ComboBox ness, ComboBox conv, ComboBox situ, PictureBox perfil,
                                                     TextBox email, MaskedTextBox tell, MaskedTextBox cell, ComboBox sexo, ComboBox naturalidade,
                                                     ComboBox estcivil, MaskedTextBox nascimento, MaskedTextBox rg, MaskedTextBox cpf,          
                                                     TextBox nomepai, TextBox nomemae, ComboBox estado, TextBox cidade, TextBox endereco,       
                                                     MaskedTextBox numero, TextBox bairro, TextBox complemento, TextBox obs, ref bool okbusca)
        {
            SqlConnection conect = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conect.Open();
                cmd.Connection = conect;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", bus_id));
                bool okid = false;
                if (bus_id.Length > 7)
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM PACIENTE.ficha " +
                                      "WHERE ficha.CPF_Pac = @id";
                }
                else
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM PACIENTE.paciente " +
                                      "WHERE paciente.idPaciente = @id";
                    okid = true;
                }
                int id = (int)cmd.ExecuteScalar();
                string seleciona;
                if (id > 0)
                {
                    if (okid)
                        cmd.CommandText = "SELECT COUNT(*) FROM LOCAIS.leito " +
                                         "WHERE leito.idPaciente = @id";
                    else
                        cmd.CommandText = "SELECT COUNT(*) FROM PACIENTE.Paciente " +
                                          "INNER JOIN PACIENTE.ficha ON " +
                                          "paciente.idFicha = ficha.idFicha " +
                                          "WHERE ficha.CPF_Pac = @id";
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        seleciona = "SELECT Paciente.NomePaciente, Paciente.Necessidade, " +
                                    "Paciente.Convenio, Paciente.Situação, ficha.Email, " +
                                    "ficha.TelContato, ficha.TelPessoal, ficha.Sexo, "+
                                    "ficha.Naturalidade, ficha.EstadoCivil, ficha.DataNascimento, "+
                                    "ficha.RG_Pac, ficha.CPF_Pac, ficha.NomePai, ficha.NomeMae, "+
                                    "ficha.estado, ficha.Cidade, ficha.Endereco, ficha.Numero, "+
                                    "ficha.Bairro, ficha.Complemento, ficha.Obs "+
                                    "FROM PACIENTE.Paciente " +
                                    "INNER JOIN PACIENTE.ficha ON " +
                                    "Paciente.idFicha = ficha.idFicha " +
                                    "WHERE ficha.CPF_Pac = '" + bus_id + "'" + // AQUIIIIIIIIIIII
                                    "OR paciente.idPaciente = " + Int64.Parse(bus_id); // AQUIIIII
                        SqlCommand com = new SqlCommand(seleciona, conect);
                        SqlDataReader read = com.ExecuteReader();
                        while (read.Read())
                        {
                            string compare;
                            nome.Text = (read["NomePaciente"].ToString());
                            compare = (read["Necessidade"].ToString());
                            ness.SelectedIndex = ness.Items.IndexOf(compare);
                            compare = (read["Convenio"].ToString());
                            conv.SelectedIndex = conv.Items.IndexOf(compare);
                            compare = (read["Situação"].ToString());
                            situ.SelectedIndex = situ.Items.IndexOf(compare);
                            email.Text = (read["Email"].ToString());
                            tell.Text = (read["TelContato"].ToString());
                            cell.Text = (read["TelPessoal"].ToString());
                            compare = (read["Sexo"].ToString());
                            sexo.SelectedIndex = sexo.Items.IndexOf(compare);
                            compare = (read["Naturalidade"].ToString());
                            naturalidade.SelectedIndex = naturalidade.Items.IndexOf(compare);
                            compare = (read["EstadoCivil"].ToString());
                            estcivil.SelectedIndex = estcivil.Items.IndexOf(compare);
                            nascimento.Text = (read["DataNascimento"].ToString());
                            rg.Text = (read["RG_Pac"].ToString());
                            cpf.Text = (read["CPF_Pac"].ToString());
                            nomepai.Text = (read["NomePai"].ToString());
                            nomemae.Text = (read["NomeMae"].ToString());
                            compare = (read["Estado"].ToString());
                            estado.SelectedIndex = estado.Items.IndexOf(compare);
                            cidade.Text = (read["Cidade"].ToString());
                            endereco.Text = (read["Endereco"].ToString());
                            numero.Text = (read["Numero"].ToString());
                            bairro.Text = (read["Bairro"].ToString());
                            complemento.Text = (read["Complemento"].ToString());
                            obs.Text = (read["Obs"].ToString());
                        }
                        read.Close();
                    }
                    else
                    {
                        seleciona = "SELECT Paciente.NomePaciente, Paciente.Necessidade, " +
                                    "Paciente.Convenio, Paciente.Situação, ficha.Email, " +
                                    "ficha.TelContato, ficha.TelPessoal, ficha.Sexo, " +
                                    "ficha.Naturalidade, ficha.EstadoCivil, ficha.DataNascimento, " +
                                    "ficha.RG_Pac, ficha.CPF_Pac, ficha.NomePai, ficha.NomeMae, " +
                                    "ficha.estado, ficha.Cidade, ficha.Endereco,ficha.Numero, " +
                                    "ficha.Bairro, ficha.Complemento, ficha.Obs " +
                                    "FROM PACIENTE.paciente "+
                                    "INNER JOIN PACIENTE.ficha ON " +
                                    "Paciente.idFicha = ficha.idFicha " +
                                    "WHERE paciente.idPaciente= " + Int64.Parse(bus_id) +
                                    "OR ficha.CPF_Pac= '" + bus_id + "'";
                        SqlCommand com = new SqlCommand(seleciona, conect);
                        SqlDataReader read = com.ExecuteReader();
                        while (read.Read())
                        {
                            string compare;
                            nome.Text = (read["NomePaciente"].ToString());
                            compare = (read["Necessidade"].ToString());
                            ness.SelectedIndex = ness.Items.IndexOf(compare);
                            compare = (read["Convenio"].ToString());
                            conv.SelectedIndex = conv.Items.IndexOf(compare);
                            compare = (read["Situação"].ToString());
                            situ.SelectedIndex = situ.Items.IndexOf(compare);
                            email.Text = (read["Email"].ToString());
                            tell.Text = (read["TelContato"].ToString());
                            cell.Text = (read["TelPessoal"].ToString());
                            compare = (read["Sexo"].ToString());
                            sexo.SelectedIndex = sexo.Items.IndexOf(compare);
                            compare = (read["Naturalidade"].ToString());
                            naturalidade.SelectedIndex = naturalidade.Items.IndexOf(compare);
                            compare = (read["EstadoCivil"].ToString());
                            estcivil.SelectedIndex = estcivil.Items.IndexOf(compare);
                            nascimento.Text = (read["DataNascimento"].ToString());
                            rg.Text = (read["RG_Pac"].ToString());
                            cpf.Text = (read["CPF_Pac"].ToString());
                            nomepai.Text = (read["NomePai"].ToString());
                            nomemae.Text = (read["NomeMae"].ToString());
                            compare = (read["Estado"].ToString());
                            estado.SelectedIndex = estado.Items.IndexOf(compare);
                            cidade.Text = (read["Cidade"].ToString());
                            endereco.Text = (read["Endereco"].ToString());
                            numero.Text = (read["Numero"].ToString());
                            bairro.Text = (read["Bairro"].ToString());
                            complemento.Text = (read["Complemento"].ToString());
                            obs.Text = (read["Obs"].ToString());
                        }
                        read.Close();
                    }
                    if (okid)
                        cmd.CommandText = "SELECT ficha.Imagem_Pac FROM PACIENTE.Paciente " +
                        "INNER JOIN PACIENTE.ficha ON PACIENTE.idFicha = ficha.idFicha " +
                        "WHERE paciente.idPaciente=@id";
                    else
                        cmd.CommandText = "SELECT ficha.Imagem_Pac FROM PACIENTE.Paciente " +
                       "INNER JOIN PACIENTE.ficha ON PACIENTE.idFicha = ficha.idFicha " +
                       "WHERE ficha.CPF_Pac=@id";
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader tabela = cmd.ExecuteReader();
                    if (tabela.Read())
                    {
                        byte[] bdebyte = new Byte[0];
                        bdebyte = (Byte[])tabela.GetSqlBinary(0);
                        MemoryStream ms_data = new MemoryStream(bdebyte);
                        perfil.Image = Image.FromStream(ms_data);
                        perfil.SizeMode = PictureBoxSizeMode.Zoom; // Mundando tamanho img
                    }
                    cmd.Connection.Close();
                }
                else
                {
                    okbusca = false;
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message + "\n" + cmd.CommandText);
            }
            finally
            {
                conect.Close();
            }
            return okbusca;
        }

        public static void Update_DadosPaciente(string bus_id, string nome, 
                                                string necess, string conv, 
                                                string situ, string telefone1,
                                                string telefone2, string email,
                                                string sexo, string rgPac,
                                                string cpfPac, string naturalidadePac,
                                                string nascimentoPac, string nomePaiPac,
                                                string nomeMaePac, string estadoCivilPac,
                                                string estadoPac, string cidadePac,
                                                string enderecoPac, string numeroPac,
                                                string bairroPac, string complementoPac,
                                                string observacaoPac, string caminho_imagem, bool checarimg)
        {
            SqlCommand cmd = getCmd();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", bus_id));
                cmd.Parameters.Add(new SqlParameter("@Nome", nome));
                cmd.Parameters.Add(new SqlParameter("@Ness", necess));
                cmd.Parameters.Add(new SqlParameter("@Conv", conv));
                cmd.Parameters.Add(new SqlParameter("@Situ", situ));
                //------------ Fim Paciente, começo ficha -----------//
                cmd.Parameters.Add(new SqlParameter("@Tell1", telefone1));
                cmd.Parameters.Add(new SqlParameter("@Tell2", telefone2));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@sexo", sexo));
                cmd.Parameters.Add(new SqlParameter("@rg", rgPac));
                cmd.Parameters.Add(new SqlParameter("@cpf", cpfPac.Replace("-", "").Replace(",", "").Replace(" ", "")));
                cmd.Parameters.Add(new SqlParameter("@natu", naturalidadePac));
                cmd.Parameters.Add(new SqlParameter("@nascimento", nascimentoPac));
                cmd.Parameters.Add(new SqlParameter("@npai", nomePaiPac));
                cmd.Parameters.Add(new SqlParameter("@nmae", nomeMaePac));
                cmd.Parameters.Add(new SqlParameter("@estcivil", estadoCivilPac));
                cmd.Parameters.Add(new SqlParameter("@estado", estadoPac));
                cmd.Parameters.Add(new SqlParameter("@cidade", cidadePac));
                cmd.Parameters.Add(new SqlParameter("@ender", enderecoPac));
                cmd.Parameters.Add(new SqlParameter("@num", numeroPac));
                cmd.Parameters.Add(new SqlParameter("@bairro", bairroPac));
                cmd.Parameters.Add(new SqlParameter("@comple", complementoPac));
                cmd.Parameters.Add(new SqlParameter("@obs", observacaoPac));
                bool okid = false;
                if (bus_id.Length > 7)
                {
                    cmd.CommandText = "UPDATE PACIENTE.Paciente SET " +
                                      "NomePaciente=@Nome,Necessidade=@Ness,Convenio=@Conv,Situação=@Situ " +
                                      "FROM Paciente.paciente " +
                                      "INNER JOIN PACIENTE.ficha ON " +
                                      "paciente.idFicha = ficha.idFicha " +
                                      "Where CPF_Pac = @id";
                }
                else
                {
                    okid = true;
                    cmd.CommandText = "UPDATE PACIENTE.Paciente SET " +
                                      "NomePaciente=@Nome,Necessidade=@Ness,Convenio=@Conv,Situação=@Situ " +
                                      "Where idPaciente = @id";
                }
                cmd.ExecuteNonQuery();

                if(okid)
                    cmd.CommandText = "UPDATE PACIENTE.ficha SET "+
                                      "TelContato=@Tell1,TelPessoal=@Tell2,Email=@email,Sexo=@sexo," +
                                      "RG_Pac=@rg,CPF_Pac=@cpf,Naturalidade=@natu,DataNascimento=@nascimento," +
                                      "NomePai=@npai,NomeMae=@nmae,EstadoCivil=@estcivil,Estado=@estado," +
                                      "Cidade=@cidade,Endereco=@ender,Numero=@num,Bairro=@bairro," +
                                      "Complemento=@comple,Obs=@obs " +
                                      "FROM PACIENTE.ficha " +
                                      "INNER JOIN PACIENTE.paciente ON " +
                                      "ficha.idFicha = paciente.idficha " +
                                      "WHERE idPaciente = @id";
                else
                    cmd.CommandText = "UPDATE PACIENTE.ficha SET " +
                                      "TelContato=@Tell1,TelPessoal=@Tell2,Email=@email,Sexo=@sexo," +
                                      "RG_Pac=@rg,CPF_Pac=@cpf,Naturalidade=@natu,DataNascimento=@nascimento," +
                                      "NomePai=@npai,NomeMae=@nmae,EstadoCivil=@estcivil,Estado=@estado," +
                                      "Cidade=@cidade,Endereco=@ender,Numero=@num,Bairro=@bairro," +
                                      "Complemento=@comple,Obs=@obs " +
                                      "WHERE CPF_Pac = @id";

                cmd.ExecuteNonQuery();
                // Se o checar imagem for verdadeiro, alterou a imagem!
                if (checarimg)
                {
                    if (okid)
                        cmd.CommandText = "UPDATE PACIENTE.ficha SET Imagem_Pac = " +
                                          "(SELECT * FROM OPENROWSET (BULK '" + caminho_imagem + "', SINGLE_BLOB) myimage) " +
                                          "WHERE ficha.idFicha = " +
                                          "(SELECT paciente.idFicha FROM PACIENTE.ficha " +
                                          "INNER JOIN PACIENTE.Paciente ON " +
                                          "Paciente.idFicha = ficha.idFicha " +
                                          "where paciente.idPaciente = @id)";
                    else
                        cmd.CommandText = "UPDATE PACIENTE.ficha SET Imagem_Pac = (SELECT * FROM OPENROWSET(BULK '"
                                        + caminho_imagem + "', SINGLE_BLOB) myimage) WHERE CPF_Pac = @id";
                    cmd.ExecuteNonQuery();
                }
                cmd.Connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public static bool Select_All_Dados_Funcionario(string bus_id, TextBox nome,
                                                        MaskedTextBox rg, MaskedTextBox cpf,
                                                        TextBox status, ComboBox funcao,
                                                        MaskedTextBox horario, ComboBox especializacao,
                                                        PictureBox perfil, ref bool okbusca)
        {
            SqlConnection conect = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conect.Open();
                cmd.Connection = conect;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", bus_id));
                bool okid = false;
                if (bus_id.Length > 7)
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM FUNCIONARIO.funcionario " +
                                      "WHERE funcionario.CPF_Fun = @id";
                }
                else
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM FUNCIONARIO.funcionario " +
                                      "WHERE funcionario.idFuncionario = @id";
                    okid = true;
                }
                int id = (int)cmd.ExecuteScalar();
                string seleciona;
                if (id > 0)
                {
                    seleciona = "SELECT funcionario.Nome_Fun, funcionario.RG_Fun, funcionario.CPF_Fun, funcionario.StatusFun " +
                                "FROM FUNCIONARIO.funcionario " +
                                "WHERE funcionario.idFuncionario= " + Int64.Parse(bus_id) +
                                "OR funcionario.CPF_Fun= '" + bus_id + "'";
                    SqlCommand com = new SqlCommand(seleciona, conect);
                    SqlDataReader read = com.ExecuteReader();
                    while (read.Read())
                    {
                        nome.Text = (read["Nome_Fun"].ToString());
                        rg.Text = (read["RG_Fun"].ToString());
                        cpf.Text = (read["CPF_Fun"].ToString());
                        status.Text = (read["StatusFun"].ToString());
                    }
                    read.Close();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT idMedicos FROM FUNCIONARIO.funcionario " +
                                      "WHERE funcionario.idFuncionario = " + Int64.Parse(bus_id) +
                                      "OR funcionario.CPF_Fun= '" + bus_id + "'";
                    int tipo = (int)cmd.ExecuteScalar();
                    if(tipo >= 300)
                    {
                        funcao.SelectedIndex = funcao.Items.IndexOf("Médico");
                        seleciona = "SELECT medico.Horario_Med, medico.Especializacao " +
                                    "FROM FUNCIONARIO.Medico " +
                                    "INNER JOIN FUNCIONARIO.funcionario ON funcionario.idMedicos = medico.idMedicos " +
                                    "WHERE funcionario.idFuncionario= " + Int64.Parse(bus_id) +
                                    " OR funcionario.CPF_Fun= '" + bus_id + "'";
                        SqlCommand com2 = new SqlCommand(seleciona, conect);
                        SqlDataReader read2 = com2.ExecuteReader();
                        while (read2.Read())
                            {
                                string compare;
                                horario.Text = (read2["Horario_Med"].ToString().Substring(0,5));
                                compare = (read2["Especializacao"].ToString());
                                especializacao.SelectedIndex = especializacao.Items.IndexOf(compare);
                             }
                            read2.Close();
                    }
                    else
                        funcao.SelectedIndex = funcao.Items.IndexOf("Enfermeiro");

                    if (okid)
                        cmd.CommandText = "SELECT funcionario.Img_Fun FROM FUNCIONARIO.funcionario " +
                        "WHERE funcionario.idFuncionario=@id";
                    else
                        cmd.CommandText = "SELECT funcionario.Img_Fun FROM FUNCIONARIO.funcionario " +
                       "WHERE funcionario.CPF_Fun=@id";
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader tabela = cmd.ExecuteReader();
                    if (tabela.Read())
                    {
                        byte[] bdebyte = new Byte[0];
                        bdebyte = (Byte[])tabela.GetSqlBinary(0);
                        MemoryStream ms_data = new MemoryStream(bdebyte);
                        perfil.Image = Image.FromStream(ms_data);
                        perfil.SizeMode = PictureBoxSizeMode.Zoom; // Mundando tamanho img
                    }
                    cmd.Connection.Close();
                }
                else
                {
                    okbusca = false;
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message + "\n" + cmd.CommandText);
            }

            finally
            {
                conect.Close();
            }
            return okbusca;
        }

        public static void Update_DadosFuncionario(string bus_id, string nomefun,
                                                   string rgfun, string cpffun,
                                                   string statusfun, string funcaofun,
                                                   string horariofun, string especializacaofun,
                                                   string caminho_imagem, bool checarimg)
        {

            SqlCommand cmd = getCmd();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", bus_id));
                cmd.Parameters.Add(new SqlParameter("@Nome", nomefun));
                cmd.Parameters.Add(new SqlParameter("@rg", rgfun));
                cmd.Parameters.Add(new SqlParameter("@cpf", cpffun.Replace("-", "").Replace(",", "").Replace(" ", "")));
                cmd.Parameters.Add(new SqlParameter("@status", statusfun));
                cmd.Parameters.Add(new SqlParameter("@horario", horariofun));
                cmd.Parameters.Add(new SqlParameter("@especializacao", especializacaofun));
                bool okid = false;
                if (bus_id.Length > 7)
                {
                    cmd.CommandText = "UPDATE FUNCIONARIO.funcionario SET " +
                                      "Nome_Fun=@Nome,RG_Fun=@rg, CPF_Fun=@cpf, StatusFun=@status " +
                                      "WHERE CPF_Fun = @id";

                }
                else
                {
                    okid = true;
                    cmd.CommandText = "UPDATE FUNCIONARIO.funcionario SET " +
                                      "Nome_Fun=@Nome,RG_Fun=@rg, CPF_Fun=@cpf, StatusFun=@status " +
                                      "Where idFuncionario = @id";
                }
                cmd.ExecuteNonQuery();

                 if (funcaofun == "Médico" && okid)
                {
                    cmd.CommandText = "UPDATE FUNCIONARIO.Medico SET " +
                                      "Horario_Med=@horario, Especializacao=@especializacao " +
                                      "FROM FUNCIONARIO.Medico "+
                                      "INNER JOIN FUNCIONARIO.Funcionario ON funcionario.idMedicos = medico.idMedicos "+
                                      "WHERE idFuncionario = @id";
                    cmd.ExecuteNonQuery();
                }
                else if (funcaofun == "Médico" && okid == false)
                {
                    cmd.CommandText = "UPDATE FUNCIONARIO.Medico SET " +
                                      "Horario_Med=@horario, Especializacao=@especializacao " +
                                      "FROM FUNCIONARIO.Medico " +
                                      "INNER JOIN FUNCIONARIO.Funcionario ON funcionario.idMedicos = medico.idMedicos " +
                                      "WHERE CPF_Fun = @id";
                    cmd.ExecuteNonQuery();
                }
                // Se o checar imagem for verdadeiro, alterou a imagem!
                if (checarimg)
                {
                    if (okid)
                        cmd.CommandText = "UPDATE FUNCIONARIO.funcionario SET Img_Fun = " +
                                          "(SELECT * FROM OPENROWSET (BULK '" + caminho_imagem + "', SINGLE_BLOB) myimage) " +
                                          "WHERE funcionario.idFuncionario = @id ";
                    else
                        cmd.CommandText = "UPDATE FUNCIONARIO.funcionario SET Img_Fun = " +
                                          "(SELECT * FROM OPENROWSET (BULK '" + caminho_imagem + "', SINGLE_BLOB) myimage)" +
                                          "WHERE funcionario.CPF_Fun = @id";
                    cmd.ExecuteNonQuery();
                }
                cmd.Connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public static bool Select_User(string bus_id, Label user, ref bool okbusca)
        {
            SqlConnection conect = new SqlConnection(strConexao);
            SqlCommand cmd = new SqlCommand();
            try
            {
                conect.Open();
                cmd.Connection = conect;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", bus_id));
                cmd.CommandText = "SELECT COUNT(*) FROM ENTRAR.Login " +
                                  "WHERE login.idFuncionario = @id";
                int cont = (int)cmd.ExecuteScalar();
                string seleciona;
                if (cont > 0)
                {
                    seleciona = "SELECT usuario FROM ENTRAR.Login " +
                                "WHERE login.idFuncionario= "+bus_id;
                    SqlCommand com = new SqlCommand(seleciona, conect);
                    SqlDataReader read = com.ExecuteReader();
                    while (read.Read())
                    {
                        user.Text = (read["usuario"].ToString());
                    }
                    read.Close();
                }
                else
                {
                    okbusca = false;
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message + "\n" + cmd.CommandText);
            }

            finally
            {
                conect.Close();
            }
            return okbusca;
        }

        public static void Update_Password(string idfun, string senha)
        {
            var hash = new Hash(SHA512.Create());
            SqlCommand cmd = getCmd();
            try
            {
               
                cmd.Parameters.Add(new SqlParameter("@idfun", idfun));
                cmd.Parameters.Add(new SqlParameter("@Senha", hash.CriptografarSenha(senha)));
                cmd.CommandText = "UPDATE ENTRAR.Login SET Senha=@Senha WHERE idFuncionario=@idfun";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
