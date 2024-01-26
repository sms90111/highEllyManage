namespace highellyManage
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGradeMng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGradeMng
            // 
            this.btnGradeMng.Location = new System.Drawing.Point(65, 130);
            this.btnGradeMng.Name = "btnGradeMng";
            this.btnGradeMng.Size = new System.Drawing.Size(121, 26);
            this.btnGradeMng.TabIndex = 2;
            this.btnGradeMng.Text = "성적그래프";
            this.btnGradeMng.UseVisualStyleBackColor = true;
            this.btnGradeMng.Click += new System.EventHandler(this.btnGradeMng_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 831);
            this.Controls.Add(this.btnGradeMng);
            this.Font = new System.Drawing.Font("달서힐링체Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 26);
            this.Text = "하이엘리 관리 프로그램";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGradeMng;
    }
}

