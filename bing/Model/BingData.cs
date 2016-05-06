using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bing
{
public class Rootobject
{
    public Image[] images { get; set; }
    public Tooltips tooltips { get; set; }
}

public class Tooltips
{
    public string loading { get; set; }
    public string previous { get; set; }
    public string next { get; set; }
    public string walle { get; set; }
    public string walls { get; set; }
    public string play { get; set; }
    public string pause { get; set; }
}

public class Image
{
    public string startdate { get; set; }
    public string fullstartdate { get; set; }
    public string enddate { get; set; }
    public string url { get; set; }
    public string urlbase { get; set; }
    public string copyright { get; set; }
    public string copyrightlink { get; set; }
    public bool wp { get; set; }
    public string hsh { get; set; }
    public int drk { get; set; }
    public int top { get; set; }
    public int bot { get; set; }
    public object[] hs { get; set; }
    public Msg[] msg { get; set; }
    public Vid vid { get; set; }
}
    /// <summary>
    /// 图片声音
    /// </summary>
public class Vid
{
    public string[][] sources { get; set; }
    public bool loop { get; set; }
    public string image { get; set; }
    public string caption { get; set; }
    public string captionlink { get; set; }
    public bool dark { get; set; }
}
    /// <summary>
    /// 图片故事
    /// </summary>
public class Msg
{
    public string title { get; set; }
    public string link { get; set; }
    public string text { get; set; }
}

}
