using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


class Pessoa
{
    public string id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
}




public partial class Formulario : System.Web.UI.Page
{

    private List<Pessoa> listaPessoa;
    string sessao = "dfasdfs";

    protected void Page_Load(object sender, EventArgs e)
    {   
  
        if (Session[sessao] == null)
        {
            listaPessoa = new List<Pessoa>();
        }
        else
        {            
            listaPessoa = (List<Pessoa>)Session[sessao];
            CarregaGV();
        }
    }


    private void CarregaGV()
    {        
        GridView1.DataSource = listaPessoa.OrderBy(x => x.Nome).ToList();     
        GridView1.DataBind();   
        Label1.Text = "O total é: " + listaPessoa.Count;

        CarregaDrop();

    }


    private void CarregaDrop()
    {
        List<string> list = new List<string>();


        DropDownList1.DataValueField = "id";
        DropDownList1.DataTextField = "Nome";
        
        /*foreach (var item in listaPessoa)
        {
            list.Add(item.Nome + " - " + item.Email);
        }*/

        DropDownList1.DataSource = listaPessoa;
        DropDownList1.DataBind();

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        var p = new Pessoa();
        p.Nome = TextBox1.Text;
        p.Email = TextBox2.Text;
               
        if (Session[sessao] == null)        
            listaPessoa = new List<Pessoa>();          
        else        
            listaPessoa = (List<Pessoa>)Session[sessao];

        listaPessoa.Add(p);        
        Session[sessao] = listaPessoa;
        CarregaGV();
    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

