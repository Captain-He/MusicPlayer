using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;

public partial class Play_Play : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {


    }

    public string CreaFile()
    {

        string Mname = "playlist/" + User.Identity.Name.ToString() + ".asx";
        DataDataContext Mdata = new DataDataContext();
        string Lmstr = "<asx VERSION=\"3.0\">\n";
        string[] Mytt = Request.QueryString["Myid"].ToString().Split(new char[] { ',' });
        var m = from o in Mdata.music where Mytt.Contains(o.id.ToString()) select new { o.url };
        foreach (var t in m)
        {
            Lmstr += "<entry>\n";
            Lmstr += "<REF HREF=\"" + t.url.ToString() + "\"/>\n";
            Lmstr += "</entry>\n";
        }
        Lmstr += "</asx>";
        string file_path = Server.MapPath(Mname);
        StreamWriter fs = new StreamWriter(file_path, false);
        fs.WriteLine(Lmstr);
        fs.Close();
        return Mname;


    }
    public string lm()
    {
        return CreaFile();
    }
}