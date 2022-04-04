using ForumInterfacesBase.Entity;

namespace ForumDomains.DataEntities.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
