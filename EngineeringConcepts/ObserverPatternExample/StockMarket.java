import java.util.*;

public class StockMarket implements Stock {

    private List<Observer> list = new ArrayList<>();
    private double price;

    public void register(Observer o){
        list.add(o);
    }

    public void deregister(Observer o){
        list.remove(o);
    }

    public void setPrice(double price){
        this.price = price;
        notifyObservers();
    }

    public void notifyObservers(){
        for(Observer o:list)
            o.update(price);
    }
}