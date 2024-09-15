public class ReceiverBehaviour : GunComponentBehaviour
{
    public override ShootData Shoot(ShootData data)
    {
        data.recoil += 76;
        return data;
        //throw new System.NotImplementedException();
    }
}