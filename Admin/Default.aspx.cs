using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;

public partial class Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void fbit_Click(object sender, EventArgs e)
    {
        if (FileUpload1.FileName == "" || FileUpload1.FileName == null)
            return;
        string[] fileArr = FileUpload1.FileName.Split('\\');
        string fileNstr = fileArr[fileArr.Length-1];
        string webDir = Server.MapPath("/play/.") + "\\music\\";
        if (!Directory.Exists(webDir))
            Directory.CreateDirectory(webDir);
        FileUpload1.SaveAs(webDir + fileNstr);
        DataDataContext db = new DataDataContext();
        var yy = new music
        {
            name= name.Text,
            who = who.Text,
            date = DateTime.Now,
            url="/Play/Music/"+fileNstr
        };

        db.music.InsertOnSubmit(yy);
        db.SubmitChanges();
        GridView1.DataBind();
        
        

    }
    protected void Delbt_Click(object sender, EventArgs e)
    {
        DataDataContext Mdata = new DataDataContext();
        string[] DMfile = Directory.GetFiles(Server.MapPath("/Play/.") + "\\music\\");
        string [] mm = Mdata.music.Select(p =>p.url).ToArray() ;
        for (int i = 0; i < mm.Length; i++) 
        {
            mm[i] = Server.MapPath(mm[i]);
        }
        foreach (var i in DMfile.Except(mm)) 
        {
            File.Delete(i);
        }
        ScriptManager.RegisterClientScriptBlock(UpdatePanel1, GetType(), "Click", "alert('已成功处理垃圾文件');", true);

            }
}
