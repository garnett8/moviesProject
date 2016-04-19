namespace FavoriteMovies
{
    partial class MovieView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpMovies = new System.Windows.Forms.GroupBox();
            this.gridMovies = new System.Windows.Forms.DataGridView();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDatabaseDataSet = new FavoriteMovies.MovieDatabaseDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.movieDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new FavoriteMovies.MovieDatabaseDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new FavoriteMovies.MovieDatabaseDataSetTableAdapters.TableAdapterManager();
            this.grpMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMovies
            // 
            this.grpMovies.Controls.Add(this.gridMovies);
            this.grpMovies.Location = new System.Drawing.Point(110, 91);
            this.grpMovies.Name = "grpMovies";
            this.grpMovies.Size = new System.Drawing.Size(1253, 461);
            this.grpMovies.TabIndex = 0;
            this.grpMovies.TabStop = false;
            this.grpMovies.Text = "Movies";
            // 
            // gridMovies
            // 
            this.gridMovies.AllowUserToAddRows = false;
            this.gridMovies.AllowUserToDeleteRows = false;
            this.gridMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridMovies.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridMovies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovies.Location = new System.Drawing.Point(22, 25);
            this.gridMovies.MultiSelect = false;
            this.gridMovies.Name = "gridMovies";
            this.gridMovies.ReadOnly = true;
            this.gridMovies.RowTemplate.Height = 28;
            this.gridMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMovies.Size = new System.Drawing.Size(1212, 419);
            this.gridMovies.TabIndex = 0;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.movieDatabaseDataSet;
            // 
            // movieDatabaseDataSet
            // 
            this.movieDatabaseDataSet.DataSetName = "MovieDatabaseDataSet";
            this.movieDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 685);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1405, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 25);
            this.lblStatus.Text = "default";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1405, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClose});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(50, 29);
            this.menuFile.Text = "File";
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(140, 30);
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(110, 607);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(102, 35);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Location = new System.Drawing.Point(576, 607);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(102, 35);
            this.btnEditMovie.TabIndex = 1;
            this.btnEditMovie.Text = "Edit Movie";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.Location = new System.Drawing.Point(973, 607);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(121, 35);
            this.btnRemoveMovie.TabIndex = 2;
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = true;
            // 
            // movieDatabaseDataSetBindingSource
            // 
            this.movieDatabaseDataSetBindingSource.DataSource = this.movieDatabaseDataSet;
            this.movieDatabaseDataSetBindingSource.Position = 0;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MoviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.UpdateOrder = FavoriteMovies.MovieDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 715);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.btnEditMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpMovies);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MovieView";
            this.Text = "Favorite Movies";
            this.Load += new System.EventHandler(this.MovieView_Load);
            this.grpMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMovies;
        private System.Windows.Forms.DataGridView gridMovies;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.BindingSource movieDatabaseDataSetBindingSource;
        private MovieDatabaseDataSet movieDatabaseDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MovieDatabaseDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private MovieDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

