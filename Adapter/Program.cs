using Adapter.Adapters;

ITarget target = new MyAdapter(new Adaptee());
target.Reuest();