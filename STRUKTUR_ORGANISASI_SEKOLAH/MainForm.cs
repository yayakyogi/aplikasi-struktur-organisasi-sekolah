/*
 * Created by SharpDevelop.
 * User: PCKURO
 * Date: 19/06/2020
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace STRUKTUR_ORGANISASI_SEKOLAH
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string koneksi="server=localhost;database=struktursekolah;uid=root;password=";
		MySqlConnection connection;
		MySqlCommand cmd;
		MySqlDataAdapter adap;
		DataSet ds;
		string idUpdate,nama,tingkatan,jabatan,alamat,triview;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		// Load Data
		private void loadData(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jabatan as Jabatan,tb.alamat as Alamat,tb.tingkatan as Tingkatan FROM tb_struktur as tb";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				MessageBox.Show("Query gagal","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Insert Data
		private void InserData(){
			int id = int.Parse(textBoxNip.Text);
			nama = textBoxNama.Text;
			alamat = textBoxAlamat.Text;
			Object pilihan1 = comboBoxTingkatan.SelectedItem;
			tingkatan = pilihan1.ToString();
			Object pilihan2 = comboBoxJabatan.SelectedItem;
			jabatan = pilihan2.ToString();
			
			connection = new MySqlConnection(koneksi);
			connection.Open();
			
			try{
				cmd = connection.CreateCommand();
				cmd.CommandText = "INSERT INTO tb_struktur (id,nama,jabatan,alamat,tingkatan) VALUES (@id,@nama,@jabatan,@alamat,@tingkatan)";
				cmd.Parameters.AddWithValue("id",id);
				cmd.Parameters.AddWithValue("nama",nama);
				cmd.Parameters.AddWithValue("jabatan",jabatan);
				cmd.Parameters.AddWithValue("alamat",alamat);
				cmd.Parameters.AddWithValue("tingkatan",tingkatan);
				cmd.ExecuteNonQuery();
			}
			catch(Exception){
				MessageBox.Show("Query gagal","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
					logic();
				}
				MessageBox.Show("Data Berhasil Ditambahkan ke Database","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Reset();
			}
		}
		// Update Data
		private void UpdateData(){
			int id = int.Parse(idUpdate);
			nama = textBoxNama.Text;
			alamat = textBoxAlamat.Text;
			Object pilihan1 = comboBoxTingkatan.SelectedItem;
			tingkatan = pilihan1.ToString();
			Object pilihan2 = comboBoxJabatan.SelectedItem;
			jabatan = pilihan2.ToString();
			
			connection = new MySqlConnection(koneksi);
			connection.Open();
			
			try{
				cmd = connection.CreateCommand();
				cmd.CommandText = "UPDATE tb_struktur SET nama=@nama,jabatan=@jabatan,alamat=@alamat,tingkatan=@tingkatan WHERE id=@id";
				cmd.Parameters.AddWithValue("id",id);
				cmd.Parameters.AddWithValue("nama",nama);
				cmd.Parameters.AddWithValue("jabatan",jabatan);
				cmd.Parameters.AddWithValue("alamat",alamat);
				cmd.Parameters.AddWithValue("tingkatan",tingkatan);
				cmd.ExecuteNonQuery();
			}
			catch(Exception){
				MessageBox.Show("Query gagal","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
					logic();
				}
				MessageBox.Show("Data Berhasil di Update ke Database","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Reset();
			}
		}
		// Delete Data
		private void DeleteData(){
			DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data "+textBoxNama.Text+" ?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
			if(result==DialogResult.Yes){
				int id = int.Parse(idUpdate);
				connection = new MySqlConnection(koneksi);
				connection.Open();
				cmd = connection.CreateCommand();
				cmd.CommandText = "DELETE FROM tb_struktur WHERE id=@id";
				cmd.Parameters.AddWithValue("id",id);
				cmd.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Data berhasil dihapus","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
				logic();
				Reset();
			}
		}
		// Reset Data
		private void Reset(){
			textBoxNip.Clear();
			textBoxNama.Clear();
			textBoxAlamat.Clear();
		}
		/*
		 * Tampilkan Data Berdasarkan Pilihan Dari TreeView
		 */
		// Tampilkan data dengan tingkat Pimpinan Tinggi
		// Load Data
		private void loadPT(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jabatan as Jabatan,tb.alamat as Alamat,tb.tingkatan as Tingkatan FROM tb_struktur as tb WHERE tb.tingkatan LIKE '%Pimpinan Tinggi%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				MessageBox.Show("Query gagal","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Tampilkan data dengan tingkat Laboratorium
		private void loadLab(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jabatan as Jabatan,tb.alamat as Alamat,tb.tingkatan as Tingkatan FROM tb_struktur as tb WHERE tb.tingkatan LIKE '%Staf Laboratorium%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				MessageBox.Show("Query gagal","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Tampilkan data dengan tingkat Tata Usaha
		private void loadTU(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jabatan as Jabatan,tb.alamat as Alamat,tb.tingkatan as Tingkatan FROM tb_struktur as tb WHERE tb.tingkatan LIKE '%Staf Tata Usaha%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				MessageBox.Show("Query gagal","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// Tampilkan data dengan tingkat Guru
		private void loadGuru(){
			connection = new MySqlConnection(koneksi);
			connection.Open();
			try{
				string sql = "SELECT tb.id as ID,tb.nama as Nama,tb.jabatan as Jabatan,tb.alamat as Alamat,tb.tingkatan as Tingkatan FROM tb_struktur as tb WHERE tb.tingkatan LIKE '%Guru%'";
				cmd = new MySqlCommand(sql,connection);
				adap = new MySqlDataAdapter(cmd);
				ds = new DataSet();
				adap.Fill(ds);
				dataGridView1.DataSource=ds.Tables[0].DefaultView;
			}
			catch(Exception){
				MessageBox.Show("Query gagal","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
			}
			finally{
				if(connection.State==ConnectionState.Open){
					connection.Close();
				}
			}
		}
		// ComboBox
		private void PilihanCombobox(){
			Object pilihan = comboBoxTingkatan.SelectedItem;
			tingkatan = pilihan.ToString();
			if(tingkatan=="Pimpinan Tinggi"){
				comboBoxJabatan.Items.Clear();
				comboBoxJabatan.Items.Add("Kepala Sekolah");
				comboBoxJabatan.Items.Add("Komite Sekolah");
				comboBoxJabatan.Items.Add("Wakasek Kurikulum");
				comboBoxJabatan.Items.Add("Wakasek Kesiswaan");
			}
			else if(tingkatan=="Staf Laboratorium"){
				comboBoxJabatan.Items.Clear();
				comboBoxJabatan.Items.Add("Kepala Perpustakaan");
				comboBoxJabatan.Items.Add("Kepala Lab. IPA");
				comboBoxJabatan.Items.Add("Kepala Lab. Komputer");
			}
			else if(tingkatan=="Staf Tata Usaha"){
				comboBoxJabatan.Items.Clear();
				comboBoxJabatan.Items.Add("Personalia");
				comboBoxJabatan.Items.Add("Bendahara BOS");
				comboBoxJabatan.Items.Add("Kesiswaan");
				comboBoxJabatan.Items.Add("Persuratan");
			}
			else if(tingkatan=="Guru"){
				comboBoxJabatan.Items.Clear();
				comboBoxJabatan.Items.Add("Guru PAI");
				comboBoxJabatan.Items.Add("Guru Bhs Indonesia");
				comboBoxJabatan.Items.Add("Guru Pkn");
				comboBoxJabatan.Items.Add("Guru IPA");
				comboBoxJabatan.Items.Add("Guru Matematika");
				comboBoxJabatan.Items.Add("Guru Bhs Inggris");
				comboBoxJabatan.Items.Add("Guru Bhs Jawa");
				comboBoxJabatan.Items.Add("Guru IPS");
				comboBoxJabatan.Items.Add("Guru Penjas");
				comboBoxJabatan.Items.Add("Guru Seni Budaya");
				comboBoxJabatan.Items.Add("Guru TIK");
				comboBoxJabatan.Items.Add("Guru BK");
			}
		}
		// Otomatis meload data sesuai pilihan treeview
		private void logic(){
			Object pilihan = comboBoxTingkatan.SelectedItem;
			tingkatan = pilihan.ToString();
			if(tingkatan=="Pimpinan Tinggi") loadPT();
			else if(tingkatan=="Staf Laboratorium") loadLab();
			else if(tingkatan=="Staf Tata Usaha") loadTU();
			else if(tingkatan=="Guru") loadGuru();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			treeView1.Nodes.Add("Struktur Organisasi");
			treeView1.Nodes[0].Nodes.Add("Pimpinan");
			treeView1.Nodes[0].Nodes[0].Nodes.Add("Pimpinan Tinggi");
			
			treeView1.Nodes[0].Nodes.Add("Staf");
			treeView1.Nodes[0].Nodes[1].Nodes.Add("Laboratorium");
			treeView1.Nodes[0].Nodes[1].Nodes.Add("Tata Usaha");
			
			treeView1.Nodes[0].Nodes.Add("Guru");
			treeView1.Nodes[0].Nodes[2].Nodes.Add("Data Guru");
		
			comboBoxTingkatan.Items.Add("Pimpinan Tinggi");
			comboBoxTingkatan.Items.Add("Staf Laboratorium");
			comboBoxTingkatan.Items.Add("Staf Tata Usaha");
			comboBoxTingkatan.Items.Add("Guru");
		}
		void ComboBoxTingkatanSelectedIndexChanged(object sender, EventArgs e)
		{
			PilihanCombobox();
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			idUpdate = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			nama = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
			jabatan = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
			alamat = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
			tingkatan = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
			textBoxNip.Enabled=false;
			textBoxNama.Text = nama;
			comboBoxJabatan.SelectedItem=jabatan;
			textBoxAlamat.Text = alamat;
			comboBoxTingkatan.SelectedItem=tingkatan;
		}
		void ButtonInsertClick(object sender, EventArgs e)
		{
			InserData();
		}
		void ButtonUpdateClick(object sender, EventArgs e)
		{
			UpdateData();
		}
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			DeleteData();
		}
		void ButtonLoadClick(object sender, EventArgs e)
		{
			triview = treeView1.SelectedNode.Text;
			if(triview=="Pimpinan Tinggi") loadPT();
			else if(triview=="Laboratorium") loadLab();
			else if(triview=="Tata Usaha") loadTU();
			else if(triview=="Data Guru") loadGuru();
		}
		
	}
}
