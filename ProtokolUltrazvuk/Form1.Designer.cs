namespace ProtokolUltrazvuk
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеУчасткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводДиаметровУчасткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вводДиаметровКамерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеУчасткаToolStripMenuItem,
            this.вводДиаметровУчасткаToolStripMenuItem,
            this.вводДиаметровКамерыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеУчасткаToolStripMenuItem
            // 
            this.данныеУчасткаToolStripMenuItem.Name = "данныеУчасткаToolStripMenuItem";
            this.данныеУчасткаToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.данныеУчасткаToolStripMenuItem.Text = "Данные участка";
            this.данныеУчасткаToolStripMenuItem.Click += new System.EventHandler(this.данныеУчасткаToolStripMenuItem_Click);
            // 
            // вводДиаметровУчасткаToolStripMenuItem
            // 
            this.вводДиаметровУчасткаToolStripMenuItem.Name = "вводДиаметровУчасткаToolStripMenuItem";
            this.вводДиаметровУчасткаToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.вводДиаметровУчасткаToolStripMenuItem.Text = "Ввод диаметров участка";
            // 
            // вводДиаметровКамерыToolStripMenuItem
            // 
            this.вводДиаметровКамерыToolStripMenuItem.Name = "вводДиаметровКамерыToolStripMenuItem";
            this.вводДиаметровКамерыToolStripMenuItem.Size = new System.Drawing.Size(198, 25);
            this.вводДиаметровКамерыToolStripMenuItem.Text = "Ввод диаметров камеры";
            this.вводДиаметровКамерыToolStripMenuItem.Click += new System.EventHandler(this.вводДиаметровКамерыToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеУчасткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводДиаметровУчасткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вводДиаметровКамерыToolStripMenuItem;
    }
}

