using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DP.Adapter.Superheros
{
    public class SuperheroAdapter : ISuperhero
    {
        private IFly _fly;
        private IShoot _shoot;
        private IWalls _walls;
        public SuperheroAdapter(IFly fly, IShoot shoot, IWalls walls)
        {
            _fly = fly;
            _shoot = shoot;
            _walls = walls;
        }

        public void Fly()
        {
            _fly.Fly();
        }

        public void GoTrougWalls()
        {
            _walls.GoThrougWalls();
        }

        public void Shoot()
        {
            _shoot.Shoot();
        }
    }
}
