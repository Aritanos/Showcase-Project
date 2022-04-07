using System.Collections.Generic;

namespace Colortribes
{
    public interface IContainer<T, K>
    {
        public Dictionary<T, K> Get { get; set; }
        public void Init();
    }
}
