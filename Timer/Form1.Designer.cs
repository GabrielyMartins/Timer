namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.img_carro = new System.Windows.Forms.PictureBox();
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.timercarro = new System.Windows.Forms.Timer(this.components);
            this.bt_parar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).BeginInit();
            this.SuspendLayout();
            // 
            // img_carro
            // 
            this.img_carro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.img_carro.Image = ((System.Drawing.Image)(resources.GetObject("img_carro.Image")));
            this.img_carro.Location = new System.Drawing.Point(12, 164);
            this.img_carro.Name = "img_carro";
            this.img_carro.Size = new System.Drawing.Size(268, 132);
            this.img_carro.TabIndex = 0;
            this.img_carro.TabStop = false;
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.Location = new System.Drawing.Point(92, 22);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(75, 23);
            this.bt_iniciar.TabIndex = 1;
            this.bt_iniciar.Text = "Iniciar carro";
            this.bt_iniciar.UseVisualStyleBackColor = true;
            this.bt_iniciar.Click += new System.EventHandler(this.bt_iniciar_Click);
            // 
            // timercarro
            // 
            this.timercarro.Interval = 5;
            this.timercarro.Tick += new System.EventHandler(this.Form1_Load);
            // 
            // bt_parar
            // 
            this.bt_parar.Location = new System.Drawing.Point(188, 22);
            this.bt_parar.Name = "bt_parar";
            this.bt_parar.Size = new System.Drawing.Size(75, 23);
            this.bt_parar.TabIndex = 2;
            this.bt_parar.Text = "Parar carro";
            this.bt_parar.UseVisualStyleBackColor = true;
            this.bt_parar.Click += new System.EventHandler(this.bt_parar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_parar);
            this.Controls.Add(this.bt_iniciar);
            this.Controls.Add(this.img_carro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_carro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_carro;
        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.Timer timercarro;
        private System.Windows.Forms.Button bt_parar;
    }
}

