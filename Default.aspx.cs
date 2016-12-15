using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Play_Click(object sender, EventArgs e)
    {
        string Mytr = "";
        CheckBox Mcheckbox;
        foreach (GridViewRow G in GridView1.Rows)
        {
            Mcheckbox = (CheckBox)G.FindControl("CheckBox2");
            if (Mcheckbox.Checked)
                Mytr += GridView1.DataKeys[G.RowIndex].Value.ToString() + ",";
        }
        if (Mytr.Length <= 0)
            return;
        else
            Mytr = Mytr.Substring(0, Mytr.Length - 1);
        ScriptManager.RegisterClientScriptBlock(UpdatePanel1, this.GetType(), "Click", "window.open(\"play/play.aspx?Myid=" + Mytr + "\",\"\",\"Width=500,Height=500\")", true);
    }
}
