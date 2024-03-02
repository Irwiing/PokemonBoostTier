using pokemon.Services;

var boostService = new BoostService();

Console.WriteLine("Informe seu TIER atual");
var currentTier = int.Parse(Console.ReadLine());

Console.WriteLine("Informe seu boost atual");
var currentBoost = int.Parse(Console.ReadLine());

Console.WriteLine("Informe seu boost ao qual você deseja alcançar");
var targetBoost = int.Parse(Console.ReadLine());



var tiersTable = boostService.GetTiersTable();
var usedStones = tiersTable[currentTier][currentBoost];
var targetStones = tiersTable[currentTier][targetBoost] - tiersTable[currentTier][currentBoost];

Console.WriteLine($"Para seu tier ({currentTier}) e nivel de boost (+{currentBoost}),");
Console.WriteLine($"Você gastou: {usedStones}");
Console.WriteLine($"Para alcançar +{targetBoost}");
Console.WriteLine($"Você precisará de {targetStones}");