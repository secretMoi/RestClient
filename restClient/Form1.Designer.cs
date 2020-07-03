namespace restClient
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxUri = new System.Windows.Forms.TextBox();
			this.textBoxResponse = new System.Windows.Forms.TextBox();
			this.buttonGo = new System.Windows.Forms.Button();
			this.labelUri = new System.Windows.Forms.Label();
			this.labelResponse = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxUri
			// 
			this.textBoxUri.Location = new System.Drawing.Point(195, 21);
			this.textBoxUri.Name = "textBoxUri";
			this.textBoxUri.Size = new System.Drawing.Size(410, 20);
			this.textBoxUri.TabIndex = 0;
			// 
			// textBoxResponse
			// 
			this.textBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxResponse.Location = new System.Drawing.Point(195, 65);
			this.textBoxResponse.Multiline = true;
			this.textBoxResponse.Name = "textBoxResponse";
			this.textBoxResponse.Size = new System.Drawing.Size(593, 373);
			this.textBoxResponse.TabIndex = 1;
			// 
			// buttonGo
			// 
			this.buttonGo.Location = new System.Drawing.Point(611, 21);
			this.buttonGo.Name = "buttonGo";
			this.buttonGo.Size = new System.Drawing.Size(75, 23);
			this.buttonGo.TabIndex = 2;
			this.buttonGo.Text = "GO";
			this.buttonGo.UseVisualStyleBackColor = true;
			this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
			// 
			// labelUri
			// 
			this.labelUri.AutoSize = true;
			this.labelUri.Location = new System.Drawing.Point(12, 21);
			this.labelUri.Name = "labelUri";
			this.labelUri.Size = new System.Drawing.Size(69, 13);
			this.labelUri.TabIndex = 3;
			this.labelUri.Text = "Request URI";
			// 
			// labelResponse
			// 
			this.labelResponse.AutoSize = true;
			this.labelResponse.Location = new System.Drawing.Point(12, 65);
			this.labelResponse.Name = "labelResponse";
			this.labelResponse.Size = new System.Drawing.Size(55, 13);
			this.labelResponse.TabIndex = 4;
			this.labelResponse.Text = "Response";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelResponse);
			this.Controls.Add(this.labelUri);
			this.Controls.Add(this.buttonGo);
			this.Controls.Add(this.textBoxResponse);
			this.Controls.Add(this.textBoxUri);
			this.Name = "Form1";
			this.Text = "REST Client";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxUri;
		private System.Windows.Forms.TextBox textBoxResponse;
		private System.Windows.Forms.Button buttonGo;
		private System.Windows.Forms.Label labelUri;
		private System.Windows.Forms.Label labelResponse;
	}
}

