    public readonly struct Coord(ushort x, ushort y)
    {
        public ushort X { get; } = x;
        public ushort Y { get; } = y;
    }

    public readonly struct Plot(Coord areaA, Coord areaB, Coord areaC, Coord areaD)
    {
        public Coord AreaA { get; } = areaA;
        public Coord AreaB { get; } = areaB;
        public Coord AreaC { get; } = areaC;
        public Coord AreaD { get; } = areaD;

        public ushort GetLargestSide()
        {
            var list = new[] { AreaA, AreaB, AreaC, AreaD };
            return list.Max(coord => Math.Max(coord.X, coord.Y));
        }
    }

    public class ClaimsHandler
    {
        private HashSet<Plot> _claimedPlots = new HashSet<Plot>();

        public void StakeClaim(Plot plot) => _claimedPlots.Add(plot);

        public bool IsClaimStaked(Plot plot) => _claimedPlots.Contains(plot);

        public bool IsLastClaim(Plot plot) => _claimedPlots.Last().Equals(plot);

        public Plot GetClaimWithLongestSide() => _claimedPlots.MaxBy(claim => claim.GetLargestSide());
    }