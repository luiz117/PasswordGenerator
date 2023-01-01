namespace Password
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.nupSize = new System.Windows.Forms.NumericUpDown();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 26);
            this.txtPass.MaxLength = 45;
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(273, 23);
            this.txtPass.TabIndex = 0;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(392, 27);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(120, 23);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Generate/Gerar";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // nupSize
            // 
            this.nupSize.Location = new System.Drawing.Point(291, 26);
            this.nupSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nupSize.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nupSize.Name = "nupSize";
            this.nupSize.Size = new System.Drawing.Size(95, 23);
            this.nupSize.TabIndex = 2;
            this.nupSize.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(12, 9);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(97, 15);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password/Senha:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(291, 9);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(84, 15);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "Size/Tamanho:";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(12, 56);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(88, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy/Copiar";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 114);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.nupSize);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Password Generator/Gerador de Senha";
            ((System.ComponentModel.ISupportInitialize)(this.nupSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPass;
        private Button btnGen;
        private NumericUpDown nupSize;
        private Label lblPass;
        private Label lblNum;
        private Button btnCopy;
    }
}