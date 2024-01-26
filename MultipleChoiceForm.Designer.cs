namespace highellyManage
{
    partial class MultipleChoiceForm
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbListening = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWord = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbListening
            // 
            this.rbListening.AutoSize = true;
            this.rbListening.Location = new System.Drawing.Point(20, 32);
            this.rbListening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbListening.Name = "rbListening";
            this.rbListening.Size = new System.Drawing.Size(78, 18);
            this.rbListening.TabIndex = 0;
            this.rbListening.TabStop = true;
            this.rbListening.Text = "Listening";
            this.rbListening.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWord);
            this.groupBox1.Controls.Add(this.rbListening);
            this.groupBox1.Location = new System.Drawing.Point(57, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "선택";
            // 
            // rbWord
            // 
            this.rbWord.AutoSize = true;
            this.rbWord.Location = new System.Drawing.Point(20, 66);
            this.rbWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbWord.Name = "rbWord";
            this.rbWord.Size = new System.Drawing.Size(54, 18);
            this.rbWord.TabIndex = 1;
            this.rbWord.TabStop = true;
            this.rbWord.Text = "word";
            this.rbWord.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(77, 141);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MultipleChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 180);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("이사만루체 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MultipleChoiceForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MultipleChoiceForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbListening;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWord;
        private System.Windows.Forms.Button btnOK;
    }
}
