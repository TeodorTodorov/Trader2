using System;

public class Order
{
    
    public DateTime TimeStamp { get; set; }
    public string clOrdID { get; set; }
    public string Symbol { get; set; }
    public string triggered { get; set; }
    public string stopPx { get; set; }
    public string OrdStatus { get; set; }
    public string OrdType { get; set; }
    public string OrderId { get; set; }
    public string Side { get; set; }
    public double? Price { get; set; }
    public int? OrderQty { get; set; }
    public int? DisplayQty { get; set; }
    public override int GetHashCode()
    {
        return clOrdID.GetHashCode();
    }
    public override string ToString()
    {
        return "ClordId: " + clOrdID + " " + "Symbol: " + Symbol + " " + "tirggered: " + triggered + " " + "stopPx: " + stopPx + " " + "OrdStatus: " + OrdStatus + " " + "Side: " + Side + " " + "Price: " + Price + " " + "OrderQty: " + OrderQty;
    }

}
