namespace PgSql
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.επέλεξεToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imdbuserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producedbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.επέλεξεToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // επέλεξεToolStripMenuItem
            // 
            this.επέλεξεToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actedToolStripMenuItem,
            this.actorToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.directorToolStripMenuItem,
            this.favoritedToolStripMenuItem,
            this.imdbuserToolStripMenuItem,
            this.movieToolStripMenuItem,
            this.producedbyToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.επέλεξεToolStripMenuItem.Name = "επέλεξεToolStripMenuItem";
            this.επέλεξεToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.επέλεξεToolStripMenuItem.Text = "Select Table";
            this.επέλεξεToolStripMenuItem.Click += new System.EventHandler(this.επέλεξεToolStripMenuItem_Click);
            // 
            // actedToolStripMenuItem
            // 
            this.actedToolStripMenuItem.Name = "actedToolStripMenuItem";
            this.actedToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.actedToolStripMenuItem.Text = "Acted";
            this.actedToolStripMenuItem.Click += new System.EventHandler(this.actedToolStripMenuItem_Click);
            // 
            // actorToolStripMenuItem
            // 
            this.actorToolStripMenuItem.Name = "actorToolStripMenuItem";
            this.actorToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.actorToolStripMenuItem.Text = "Actor";
            this.actorToolStripMenuItem.Click += new System.EventHandler(this.actorToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // directorToolStripMenuItem
            // 
            this.directorToolStripMenuItem.Name = "directorToolStripMenuItem";
            this.directorToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.directorToolStripMenuItem.Text = "Director";
            this.directorToolStripMenuItem.Click += new System.EventHandler(this.directorToolStripMenuItem_Click);
            // 
            // favoritedToolStripMenuItem
            // 
            this.favoritedToolStripMenuItem.Name = "favoritedToolStripMenuItem";
            this.favoritedToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.favoritedToolStripMenuItem.Text = "Favorited";
            this.favoritedToolStripMenuItem.Click += new System.EventHandler(this.favoritedToolStripMenuItem_Click);
            // 
            // imdbuserToolStripMenuItem
            // 
            this.imdbuserToolStripMenuItem.Name = "imdbuserToolStripMenuItem";
            this.imdbuserToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.imdbuserToolStripMenuItem.Text = "Imdb_user";
            this.imdbuserToolStripMenuItem.Click += new System.EventHandler(this.imdbuserToolStripMenuItem_Click);
            // 
            // movieToolStripMenuItem
            // 
            this.movieToolStripMenuItem.Name = "movieToolStripMenuItem";
            this.movieToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.movieToolStripMenuItem.Text = "Movie";
            this.movieToolStripMenuItem.Click += new System.EventHandler(this.movieToolStripMenuItem_Click);
            // 
            // producedbyToolStripMenuItem
            // 
            this.producedbyToolStripMenuItem.Name = "producedbyToolStripMenuItem";
            this.producedbyToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.producedbyToolStripMenuItem.Text = "Produced_by";
            this.producedbyToolStripMenuItem.Click += new System.EventHandler(this.producedbyToolStripMenuItem_Click);
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.productionToolStripMenuItem.Text = "Production";
            this.productionToolStripMenuItem.Click += new System.EventHandler(this.productionToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 402);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem επέλεξεToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imdbuserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producedbyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}