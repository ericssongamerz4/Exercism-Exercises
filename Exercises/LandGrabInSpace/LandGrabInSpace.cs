namespace Exercism_Exercises.Exercises.LandGrabInSpace
{
    public struct Coord(ushort x, ushort y)
    {
        public ushort X { get; } = x;
        public ushort Y { get; } = y;
    }

    public struct Plot(Coord areaA, Coord areaB, Coord areaC, Coord careaD)
    {
        public Coord AreaA { get; }= areaA;
        public Coord AreaB { get; }= areaB;
        public Coord AreaC { get; }= areaC;
        public Coord AreaD { get; }= careaD;
    }

    public class ClaimsHandler
    {
        private HashSet<Plot> _claimedPlots = new HashSet<Plot>();
        private Plot _latestPlot;

        public void StakeClaim(Plot plot)
        {
            if (!IsClaimStaked(plot))
            {
                _claimedPlots.Add(plot);
                _latestPlot = plot;
            }
        }

        public bool IsClaimStaked(Plot plot) => _claimedPlots.Contains(plot);
        public bool IsLastClaim(Plot plot) => _latestPlot.Equals(plot);

        public Plot GetClaimWithLongestSide() => _claimedPlots.MaxBy(claim => GetLongestSide(claim));
        private static double GetLength(Coord coord1, Coord coord2) => Math.Sqrt(Math.Pow(coord2.X - coord1.X, 2) + Math.Pow(coord2.Y - coord1.Y, 2));
        private static double GetLongestSide(Plot plot)
        {
            List<double> sides = new()
            {
                GetLength(plot.AreaA,plot.AreaB),
                GetLength(plot.AreaB, plot.AreaC),
                GetLength(plot.AreaC, plot.AreaD),
                GetLength(plot.AreaD, plot.AreaA),
            };

            return sides.Max(side => side);
        }
    }
}//Made by ericssonGamerz4