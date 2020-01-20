namespace FileSystemWatcherService
{
    partial class SecureCore
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.watcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.Filter = "*.edi";
            this.watcher.Path = "C:\\ProvaServei";
            // 
            // SecureCore
            // 
            this.ServiceName = "SecureCore";
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher watcher;
    }
}
