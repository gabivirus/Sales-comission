
namespace Sells_Comission
{
    partial class comCalculator
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.firstValueInput = new System.Windows.Forms.TextBox();
            this.sellValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comValue = new System.Windows.Forms.TextBox();
            this.comCalc = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioC);
            this.groupBox.Controls.Add(this.radioB);
            this.groupBox.Controls.Add(this.radioA);
            this.groupBox.Location = new System.Drawing.Point(21, 35);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(176, 167);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Categoria de vendedor";
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(6, 114);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(80, 17);
            this.radioC.TabIndex = 2;
            this.radioC.TabStop = true;
            this.radioC.Text = "Categoria C";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Location = new System.Drawing.Point(6, 77);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(80, 17);
            this.radioB.TabIndex = 1;
            this.radioB.TabStop = true;
            this.radioB.Text = "Categoria B";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Location = new System.Drawing.Point(6, 44);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(80, 17);
            this.radioA.TabIndex = 0;
            this.radioA.TabStop = true;
            this.radioA.Text = "Categoria A";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // firstValueInput
            // 
            this.firstValueInput.Location = new System.Drawing.Point(229, 56);
            this.firstValueInput.Name = "firstValueInput";
            this.firstValueInput.Size = new System.Drawing.Size(114, 20);
            this.firstValueInput.TabIndex = 1;
            // 
            // sellValue
            // 
            this.sellValue.AutoSize = true;
            this.sellValue.Location = new System.Drawing.Point(226, 40);
            this.sellValue.Name = "sellValue";
            this.sellValue.Size = new System.Drawing.Size(117, 13);
            this.sellValue.TabIndex = 2;
            this.sellValue.Text = "Digite o valor da venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor da comissão";
            // 
            // comValue
            // 
            this.comValue.Location = new System.Drawing.Point(229, 182);
            this.comValue.Name = "comValue";
            this.comValue.Size = new System.Drawing.Size(114, 20);
            this.comValue.TabIndex = 3;
            // 
            // comCalc
            // 
            this.comCalc.Location = new System.Drawing.Point(229, 112);
            this.comCalc.Name = "comCalc";
            this.comCalc.Size = new System.Drawing.Size(114, 23);
            this.comCalc.TabIndex = 5;
            this.comCalc.Text = "Calcular comissão";
            this.comCalc.UseVisualStyleBackColor = true;
            this.comCalc.Click += new System.EventHandler(this.comCalc_Click);
            // 
            // comCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 246);
            this.Controls.Add(this.comCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comValue);
            this.Controls.Add(this.sellValue);
            this.Controls.Add(this.firstValueInput);
            this.Controls.Add(this.groupBox);
            this.Name = "comCalculator";
            this.Text = "Calculadora de comissão";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.TextBox firstValueInput;
        private System.Windows.Forms.Label sellValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comValue;
        private System.Windows.Forms.Button comCalc;
    }
}

