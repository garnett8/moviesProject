namespace FavoriteMovies
{
    partial class MovieDetails
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
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.txtYearReleased = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieRating = new System.Windows.Forms.TextBox();
            this.lblMovieDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpGenres = new System.Windows.Forms.GroupBox();
            this.chkAction = new System.Windows.Forms.CheckBox();
            this.chkAdventure = new System.Windows.Forms.CheckBox();
            this.chkDrama = new System.Windows.Forms.CheckBox();
            this.chkScary = new System.Windows.Forms.CheckBox();
            this.chkComedy = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDetailsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpGenres.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(39, 38);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(87, 20);
            this.lblMovieTitle.TabIndex = 10;
            this.lblMovieTitle.Text = "Movie Title:";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(231, 38);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(374, 26);
            this.txtMovieTitle.TabIndex = 0;
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Location = new System.Drawing.Point(39, 94);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(123, 20);
            this.lblMovieYear.TabIndex = 9;
            this.lblMovieYear.Text = "Year Released: ";
            // 
            // txtYearReleased
            // 
            this.txtYearReleased.Location = new System.Drawing.Point(231, 94);
            this.txtYearReleased.Name = "txtYearReleased";
            this.txtYearReleased.Size = new System.Drawing.Size(374, 26);
            this.txtYearReleased.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Movie Rating:";
            // 
            // txtMovieRating
            // 
            this.txtMovieRating.Location = new System.Drawing.Point(231, 146);
            this.txtMovieRating.Name = "txtMovieRating";
            this.txtMovieRating.Size = new System.Drawing.Size(374, 26);
            this.txtMovieRating.TabIndex = 2;
            // 
            // lblMovieDesc
            // 
            this.lblMovieDesc.AutoSize = true;
            this.lblMovieDesc.Location = new System.Drawing.Point(39, 210);
            this.lblMovieDesc.Name = "lblMovieDesc";
            this.lblMovieDesc.Size = new System.Drawing.Size(138, 20);
            this.lblMovieDesc.TabIndex = 57;
            this.lblMovieDesc.Text = "Movie Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 91);
            this.textBox1.TabIndex = 3;
            // 
            // grpGenres
            // 
            this.grpGenres.Controls.Add(this.chkComedy);
            this.grpGenres.Controls.Add(this.chkScary);
            this.grpGenres.Controls.Add(this.chkDrama);
            this.grpGenres.Controls.Add(this.chkAdventure);
            this.grpGenres.Controls.Add(this.chkAction);
            this.grpGenres.Location = new System.Drawing.Point(43, 322);
            this.grpGenres.Name = "grpGenres";
            this.grpGenres.Size = new System.Drawing.Size(562, 89);
            this.grpGenres.TabIndex = 4;
            this.grpGenres.TabStop = false;
            this.grpGenres.Text = "Genre";
            // 
            // chkAction
            // 
            this.chkAction.AutoSize = true;
            this.chkAction.Location = new System.Drawing.Point(7, 35);
            this.chkAction.Name = "chkAction";
            this.chkAction.Size = new System.Drawing.Size(80, 24);
            this.chkAction.TabIndex = 0;
            this.chkAction.Text = "Action";
            this.chkAction.UseVisualStyleBackColor = true;
            // 
            // chkAdventure
            // 
            this.chkAdventure.AutoSize = true;
            this.chkAdventure.Location = new System.Drawing.Point(111, 35);
            this.chkAdventure.Name = "chkAdventure";
            this.chkAdventure.Size = new System.Drawing.Size(108, 24);
            this.chkAdventure.TabIndex = 1;
            this.chkAdventure.Text = "Adventure";
            this.chkAdventure.UseVisualStyleBackColor = true;
            // 
            // chkDrama
            // 
            this.chkDrama.AutoSize = true;
            this.chkDrama.Location = new System.Drawing.Point(346, 34);
            this.chkDrama.Name = "chkDrama";
            this.chkDrama.Size = new System.Drawing.Size(83, 24);
            this.chkDrama.TabIndex = 2;
            this.chkDrama.Text = "Drama";
            this.chkDrama.UseVisualStyleBackColor = true;
            // 
            // chkScary
            // 
            this.chkScary.AutoSize = true;
            this.chkScary.Location = new System.Drawing.Point(465, 34);
            this.chkScary.Name = "chkScary";
            this.chkScary.Size = new System.Drawing.Size(75, 24);
            this.chkScary.TabIndex = 3;
            this.chkScary.Text = "Scary";
            this.chkScary.UseVisualStyleBackColor = true;
            // 
            // chkComedy
            // 
            this.chkComedy.AutoSize = true;
            this.chkComedy.Location = new System.Drawing.Point(238, 33);
            this.chkComedy.Name = "chkComedy";
            this.chkComedy.Size = new System.Drawing.Size(93, 24);
            this.chkComedy.TabIndex = 4;
            this.chkComedy.Text = "Comedy";
            this.chkComedy.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(231, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDetailsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(711, 30);
            this.statusStrip1.TabIndex = 58;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDetailsStatus
            // 
            this.lblDetailsStatus.Name = "lblDetailsStatus";
            this.lblDetailsStatus.Size = new System.Drawing.Size(67, 25);
            this.lblDetailsStatus.Text = "default";
            // 
            // MovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 492);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpGenres);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMovieDesc);
            this.Controls.Add(this.txtMovieRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYearReleased);
            this.Controls.Add(this.lblMovieYear);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.lblMovieTitle);
            this.Name = "MovieDetails";
            this.Text = "MovieDetails";
            this.grpGenres.ResumeLayout(false);
            this.grpGenres.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.TextBox txtYearReleased;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieRating;
        private System.Windows.Forms.Label lblMovieDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpGenres;
        private System.Windows.Forms.CheckBox chkComedy;
        private System.Windows.Forms.CheckBox chkScary;
        private System.Windows.Forms.CheckBox chkDrama;
        private System.Windows.Forms.CheckBox chkAdventure;
        private System.Windows.Forms.CheckBox chkAction;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDetailsStatus;
    }
}