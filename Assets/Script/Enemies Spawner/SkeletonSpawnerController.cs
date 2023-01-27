public class SkeletonSpawnerController : EnemiesSpawnerController
{
    protected override void RegistrateAction()
    {
        if (AllSkeletonsManager.Instance != null)
        {
            AllSkeletonsManager.Registrate(this);
        }
    }

    protected override void RemoveRegistratationAction()
    {
        if (AllSkeletonsManager.Instance != null)
        {
            AllSkeletonsManager.Remove(this);
        }
    }
}