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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.movieDatabaseDataSet = new FavoriteMovies.MovieDatabaseDataSet();
            this.movieDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new FavoriteMovies.MovieDatabaseDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new FavoriteMovies.MovieDatabaseDataSetTableAdapters.TableAdapterManager();
            this.movieTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovies)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMovies
            // 
            this.grpMovies.Controls.Add(this.gridMovies);
            this.grpMovies.Location = new System.Drawing.Point(110, 91);
            this.grpMovies.Name = "grpMovies";
            this.grpMovies.Size = new System.Drawing.Size(984, 461);
            this.grpMovies.TabIndex = 0;
            this.grpMovies.TabStop = false;
            this.grpMovies.Text = "Movies";
            // 
            // gridMovies
            // 
            this.gridMovies.AllowUserToAddRows = false;
            this.gridMovies.AllowUserToDeleteRows = false;
            this.gridMovies.AutoGenerateColumns = false;
            this.gridMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridMovies.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridMovies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieTitleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.releaseYearDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.gridMovies.DataSource = this.moviesBindingSource;
            this.gridMovies.Location = new System.Drawing.Point(22, 25);
            this.gridMovies.Name = "gridMovies";
            this.gridMovies.ReadOnly = true;
            this.gridMovies.RowTemplate.Height = 28;
            this.gridMovies.Size = new System.Drawing.Size(944, 419);
            this.gridMovies.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 685);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1129, 30);
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
            this.menuStrip1.Size = new System.Drawing.Size(1129, 33);
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
            // movieDatabaseDataSet
            // 
            this.movieDatabaseDataSet.DataSetName = "MovieDatabaseDataSet";
            this.movieDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieDatabaseDataSetBindingSource
            // 
            this.movieDatabaseDataSetBindingSource.DataSource = this.movieDatabaseDataSet;
            this.movieDatabaseDataSetBindingSource.Position = 0;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.movieDatabaseDataSet;
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
            // movieTitleDataGridViewTextBoxColumn
            // 
            this.movieTitleDataGridViewTextBoxColumn.DataPropertyName = "MovieTitle";
            this.movieTitleDataGridViewTextBoxColumn.HeaderText = "MovieTitle";
            this.movieTitleDataGridViewTextBoxColumn.Name = "movieTitleDataGridViewTextBoxColumn";
            this.movieTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseYearDataGridViewTextBoxColumn
            // 
            this.releaseYearDataGridViewTextBoxColumn.DataPropertyName = "ReleaseYear";
            this.releaseYearDataGridViewTextBoxColumn.HeaderText = "ReleaseYear";
            this.releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
            this.releaseYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genresDataGridViewTextBoxColumn
            // 
            this.genresDataGridViewTextBoxColumn.DataPropertyName = "Genre(s)";
            this.genresDataGridViewTextBoxColumn.HeaderText = "Genre(s)";
            this.genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            this.genresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 715);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn movieTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    }
}

