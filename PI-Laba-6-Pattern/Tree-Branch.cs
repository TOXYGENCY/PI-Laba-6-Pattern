namespace PI_Laba_6_Pattern
{
    // Этот класс отвечает за отдельный композит в общем виде (конкретно в примере - абстракт компании)
    public abstract class Tree_Branch<T> : Tree_Component 
                                     where T : Tree_Component // для того, чтобы элементы могли быть и Leaf и Branch
    {
        // Список дочерних элементов
        public List<T> ChildrenList { get; protected set; }
        public Tree_Branch() 
        { 
            IsLeaf = false; 
            ChildrenList = new List<T>();
        }

        // Добавить/удалить компонент
        public void AddComp(T Comp)
        {
            if (Comp != null)
            { ChildrenList.Add(Comp); }
            else 
            { throw new ArgumentNullException("Аргумент не может быть null"); }

        }
        public void RemoveComp(T Comp)
        {
            if (Comp != null)
            { ChildrenList.Remove(Comp); }
            else 
            { throw new ArgumentNullException("Аргумент не может быть null"); }
        }

    }
}
