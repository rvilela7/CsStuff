using System;
using System.Collections.Generic;
 
namespace ObserverPattern
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Observer Design Pattern.
  /// </summary>

  class MainApp

  {
      static void Main()
    {
      IBM ibm = new IBM("IBM", 120.00);
      TP TP = new TP("TP", 10.00);

      Investor Jonhy = new Investor("João");
			Investor Rui = new Investor("Rui");

      ibm.Attach(Rui);
      ibm.Attach(Jonhy);
      ibm.Attach(new Investor("Miguel"));
      ibm.Attach(new Investor("Aga"));
			TP.Attach(Rui);

      ibm.Price = 120.10;
      ibm.Price = 121.00;
      ibm.Price = 120.50;
      TP.Price *= 2;

      ibm.Detach(Jonhy);

      ibm.Price = 120.75;
			TP.Price *= 2;
 
      Console.ReadKey();
    }
  }
   
	#region StockRegion
  abstract class Stock
  {
    private string _symbol;
    private double _price;
    private List<IInvestor> _investors = new List<IInvestor>();
    public Stock(string symbol, double price)
    {
      this._symbol = symbol;
      this._price = price;
    }
 
    public void Attach(IInvestor investor)
    {
      _investors.Add(investor);
    }
 
    public void Detach(IInvestor investor)
    {
      _investors.Remove(investor);
    }
 
    public void Notify()
    {
			_investors.ForEach(i => i.Update(this));
 
      Console.WriteLine("");
    }
 
    public double Price
    {
      get { return _price; }
      set

      {
        if (_price != value)
        {
          _price = value;
          Notify();
        }
      }
    }
 
    public string Symbol
    {
      get { return _symbol; }
    }
  }
 
  class IBM : Stock
  {
    public IBM(string symbol, double price)
      : base(symbol, price)
    {
    }
  }

	class TP : Stock
	{
		public TP(string symbol, double price)
		: base(symbol, price)
		{

		}
	}

	#endregion
   
  interface IInvestor
  {
    void Update(Stock stock);
  }
 
  class Investor : IInvestor
  {
    private string _name;
    private Stock _stock;
 
    public Investor(string name)
    {
      this._name = name;
    }
 
    public void Update(Stock stock)
    {
      Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Symbol, stock.Price);
    }
 
    public Stock Stock
    {
      get { return _stock; }
      set { _stock = value; }
    }
  }
}