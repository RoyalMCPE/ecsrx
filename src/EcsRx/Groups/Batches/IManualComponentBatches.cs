using System.Collections.Generic;
using EcsRx.Entities;

namespace EcsRx.Groups.Batches
{
    public interface IManualComponentBatches<out T> : IComponentBatches<T> where T : IBatchDescriptor
    {
        void RefreshBatches(IReadOnlyList<IEntity> entities);
    }
}