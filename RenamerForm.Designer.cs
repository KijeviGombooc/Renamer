using System.Windows.Forms;

namespace Renamer
{
    partial class RenamerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Text = "Renamer";

            this.btDir = new Button();
            this.btDir.Text = "Browse...";
            this.btDir.Location = new System.Drawing.Point(this.Size.Width - this.btDir.Size.Width - 25, 10);
            this.btDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            
            this.btConvert = new Button();
            this.btConvert.Text = "Convert";
            this.btConvert.Location = new System.Drawing.Point(this.Size.Width - this.btDir.Size.Width - 25, 70);
            this.btConvert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            
            this.tbDir = new TextBox();
            this.tbDir.Location = new System.Drawing.Point(10, 10);
            this.tbDir.Size = new System.Drawing.Size(this.btDir.Location.X - 20, 35);
            this.tbDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            
            this.tbFrom = new TextBox();
            this.tbFrom.Location = new System.Drawing.Point(10, 40);
            this.tbFrom.Size = new System.Drawing.Size(this.btDir.Location.X - 20, 35);
            this.tbFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            this.tbTo = new TextBox();
            this.tbTo.Location = new System.Drawing.Point(10, 70);
            this.tbTo.Size = new System.Drawing.Size(this.btDir.Location.X - 20, 35);
            this.tbTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            this.Controls.Add(this.tbDir);
            this.Controls.Add(this.btDir);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.btConvert);
        }

        TextBox tbDir;
        TextBox tbFrom;
        TextBox tbTo;
        Button btConvert;
        Button btDir;

        #endregion
    }
}

