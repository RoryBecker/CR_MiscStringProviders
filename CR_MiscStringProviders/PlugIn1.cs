using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;
using DevExpress.CodeRush.Extensions;

namespace CR_MiscStringProviders
{
    public partial class PlugIn1 : StandardPlugIn
    {
        // DXCore-generated code...
        #region InitializePlugIn
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();
            createRemoveSpaces();
        }
        #endregion
        #region FinalizePlugIn
        public override void FinalizePlugIn()
        {
            //
            // TODO: Add your finalization code here.
            //

            base.FinalizePlugIn();
        }
        #endregion

        public void createRemoveSpaces()
        {
            StringProvider RemoveSpaces = new StringProvider(components);
            ((System.ComponentModel.ISupportInitialize)(RemoveSpaces)).BeginInit();
            RemoveSpaces.ProviderName = "RemoveSpaces";
            RemoveSpaces.DisplayName = "RemoveSpaces";
            RemoveSpaces.GetString += RemoveSpaces_GetString;
            ((System.ComponentModel.ISupportInitialize)(RemoveSpaces)).EndInit();
        }
        private void RemoveSpaces_GetString(DevExpress.CodeRush.Core.GetStringEventArgs ea)
        {
            ea.Value = ea.Parameters.All.Replace(" ", "");
        }
    }
}