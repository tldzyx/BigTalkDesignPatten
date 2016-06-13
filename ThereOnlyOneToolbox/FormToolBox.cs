using System.Windows.Forms;

namespace ThereOnlyOneToolbox
{
    public partial class FormToolBox : Form
    {
        private static FormToolBox __instance;

        private FormToolBox()
        {
            InitializeComponent();
        }

        public static FormToolBox GetInstance()
        {
            if (null == __instance || __instance.Disposing || __instance.IsDisposed)
            {
                __instance = new FormToolBox
                {
                    MdiParent = FormMain.ActiveForm
                };
            }
            return __instance;
        }
    }
}