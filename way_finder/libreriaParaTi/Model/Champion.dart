class ChampionDetail {
  final String id;
  final String name;
  final String title;
  final String lore;
  final String img;
  final List<String> tags;
  final List<String> skins;
  ChampionDetail(this.id, this.name, this.title, this.lore, this.img, this.tags, this.skins);
}

class ChampionCard {
  final String name;
  final String title;
  final String img;
  ChampionCard(this.name, this.title, this.img);
}