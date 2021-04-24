using System.Collections.ObjectModel;
using Shop_Service.ProductFactory;

namespace Shop_Service.UndoRedo
{  
    public class Memento
    {
        public ObservableCollection<Product> productState;
        public Memento(ObservableCollection<Product> products)
        {
            productState = new ObservableCollection<Product>(products);
        }
    }

   public class AppHistory
    {
        ObservableCollection<Memento> states;
        private int currentStateId;
        public AppHistory(ObservableCollection<Product> products)
        {
            states = new ObservableCollection<Memento>();
            AddState(products);
            currentStateId = 0;
        }

        public void AddState(ObservableCollection<Product> products)
        {
            states.Add(new Memento(products));
            currentStateId++;
        }

        public Memento Undo()
        {
            if (currentStateId <= 0) return null;
            currentStateId--;
            return states[currentStateId];
        }

        public Memento Redo()
        {
            if (currentStateId >= states.Count - 1) return null;
            currentStateId++;
            return states[currentStateId];
        }
    }
}