

namespace TestesDaDonaMariana.WinApp.Compartilhado {
    public abstract class ControladorBase {

        public abstract string ToolTipInserir { get; }
        public virtual string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }
        public virtual string ToolTipVisualizar { get; }
        public virtual string ToolTipDuplicar { get; }
        public virtual string ToolTipImprimir { get; }

        public abstract string LabelTipoCadastro { get; }

        public virtual bool InserirHabilitado { get { return true; } }
        public virtual bool EditarHabilitado { get { return false; } }
        public virtual bool ExcluirHabilitado { get { return true; } }
        public virtual bool VisualizarHabilitado { get { return false; } }
        public virtual bool DuplicarHabilitado { get { return false; } }
        public virtual bool ImprimirHabilitado { get { return false; } }




        public abstract void Inserir();

        public virtual void Editar() { }

        public virtual void Duplicar() { }

        public virtual void Visualizar() { }

        public virtual void Imprimir() { }

        public abstract void Excluir();

        public abstract UserControl ObterListagem();
    }
}
