/*
 * Created by SharpDevelop.
 * User: PCKURO
 * Date: 19/06/2020
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace STRUKTUR_ORGANISASI_SEKOLAH
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNip;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAlamat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxJabatan;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.ComboBox comboBoxTingkatan;
		private System.Windows.Forms.Label label5;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNip = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAlamat = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxJabatan = new System.Windows.Forms.ComboBox();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.comboBoxTingkatan = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 12);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(201, 303);
			this.treeView1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(243, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(582, 210);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// buttonLoad
			// 
			this.buttonLoad.BackColor = System.Drawing.Color.Chartreuse;
			this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLoad.Location = new System.Drawing.Point(60, 330);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(91, 31);
			this.buttonLoad.TabIndex = 2;
			this.buttonLoad.Text = "LOAD";
			this.buttonLoad.UseVisualStyleBackColor = false;
			this.buttonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(243, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "NIP";
			// 
			// textBoxNip
			// 
			this.textBoxNip.Location = new System.Drawing.Point(349, 241);
			this.textBoxNip.Name = "textBoxNip";
			this.textBoxNip.Size = new System.Drawing.Size(183, 20);
			this.textBoxNip.TabIndex = 4;
			// 
			// textBoxNama
			// 
			this.textBoxNama.Location = new System.Drawing.Point(349, 270);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(183, 20);
			this.textBoxNama.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(243, 270);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "NAMA";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(560, 292);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "JABATAN";
			// 
			// textBoxAlamat
			// 
			this.textBoxAlamat.Location = new System.Drawing.Point(349, 301);
			this.textBoxAlamat.Name = "textBoxAlamat";
			this.textBoxAlamat.Size = new System.Drawing.Size(183, 20);
			this.textBoxAlamat.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(243, 301);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "ALAMAT";
			// 
			// comboBoxJabatan
			// 
			this.comboBoxJabatan.FormattingEnabled = true;
			this.comboBoxJabatan.Location = new System.Drawing.Point(648, 290);
			this.comboBoxJabatan.Name = "comboBoxJabatan";
			this.comboBoxJabatan.Size = new System.Drawing.Size(129, 21);
			this.comboBoxJabatan.TabIndex = 11;
			// 
			// buttonInsert
			// 
			this.buttonInsert.BackColor = System.Drawing.Color.Turquoise;
			this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInsert.Location = new System.Drawing.Point(268, 344);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(75, 31);
			this.buttonInsert.TabIndex = 12;
			this.buttonInsert.Text = "INSERT";
			this.buttonInsert.UseVisualStyleBackColor = false;
			this.buttonInsert.Click += new System.EventHandler(this.ButtonInsertClick);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.BackColor = System.Drawing.Color.Yellow;
			this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUpdate.Location = new System.Drawing.Point(457, 344);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 31);
			this.buttonUpdate.TabIndex = 13;
			this.buttonUpdate.Text = "UPDATE";
			this.buttonUpdate.UseVisualStyleBackColor = false;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.Red;
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Location = new System.Drawing.Point(634, 344);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 31);
			this.buttonDelete.TabIndex = 14;
			this.buttonDelete.Text = "DELETE";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// comboBoxTingkatan
			// 
			this.comboBoxTingkatan.FormattingEnabled = true;
			this.comboBoxTingkatan.Location = new System.Drawing.Point(648, 238);
			this.comboBoxTingkatan.Name = "comboBoxTingkatan";
			this.comboBoxTingkatan.Size = new System.Drawing.Size(129, 21);
			this.comboBoxTingkatan.TabIndex = 16;
			this.comboBoxTingkatan.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTingkatanSelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(560, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "TINGKATAN";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 387);
			this.Controls.Add(this.comboBoxTingkatan);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonInsert);
			this.Controls.Add(this.comboBoxJabatan);
			this.Controls.Add(this.textBoxAlamat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxNip);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLoad);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.treeView1);
			this.Name = "MainForm";
			this.Text = "STRUKTUR ORGANISASI SEKOLAH";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
