import 'dart:async';
import 'dart:convert';
import '../Model/Champion.dart';
import 'package:http/http.dart' as http;
import 'package:flutter/material.dart';

class DetailPage extends StatefulWidget {
  @override
  _DetailPageState createState() => _DetailPageState();
}

class _DetailPageState extends State<DetailPage>{

  final Color dorado     = Color.fromRGBO(187, 146, 95, 1);
  final Color fondo      = Colors.white10;
  final Color fondotrans = Color.fromRGBO(31, 44, 61, 0.5);
  String fondoCampeon    = "";

  @override
  Widget build(BuildContext context) {
      
    final String name = ModalRoute.of(context).settings.arguments;

    return Scaffold(
      backgroundColor: fondo,
      body: Container(
        child: FutureBuilder(
          future: getData(name),
          builder: (BuildContext context, AsyncSnapshot snapshot){
            if(snapshot.data == null){
              return _cargando();
            }
            else{
              return _deallesCampeon(snapshot.data);
            }
          },
        ),
      ),
    );
  }

  Widget _deallesCampeon(ChampionDetail champion){

    return SingleChildScrollView(
      child: Container(
        color: Colors.transparent,
        child: Column(
          children: <Widget>[
            _crearImagen(),
            _crearTitulo(champion.name, champion.title),
            _crearTags(champion.tags),
            _divider(),
            _crearSkins(champion.id, champion.skins),
            _divider(),
            _crearTexto(champion.lore),
          ],
        ),
      ),
    );
  }
  //FUNCIONES

  Future<ChampionDetail> getData(String name) async {
    http.Response response = await http.get("http://ddragon.leagueoflegends.com/cdn/9.22.1/data/en_US/champion/$name.json");
    Map<String, dynamic> m = json.decode(response.body)["data"][name];
    String img = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/$name"+"_0.jpg";
    if(fondoCampeon == ""){
      fondoCampeon = img;
    }
    List<String> tags = [];
    m["tags"].forEach((x) => tags.add(x));
    List<String> skins = [];
    m["skins"].forEach((x) => skins.add(x["num"].toString()));
    ChampionDetail championDetail = ChampionDetail(m["id"], m["name"], m["title"], m["lore"], img, tags, skins);
    return championDetail;
  }

  //WIDGETS EXTRA

  Widget _crearImagen() {
    return Container(
      width: double.infinity,
      decoration: BoxDecoration(border: Border(bottom: BorderSide(color: dorado, width: 8))),
      child: GestureDetector(
        child: Image(
          image: NetworkImage(fondoCampeon),
          height: 250.0,
          fit: BoxFit.cover,
        ),
      ),
    );
  }

  Widget _crearTitulo(String titulo, String subtitulo) {
    return Container(
      decoration: BoxDecoration(border: Border(bottom: BorderSide(color: dorado, width: 5)), color: fondotrans),
      alignment: Alignment.center,
      margin: EdgeInsets.only(bottom: 5),
      padding: EdgeInsets.symmetric(vertical: 2),
      child: Column(
        children: <Widget>[
          Text(titulo, textAlign: TextAlign.justify, style: TextStyle(color: dorado, fontSize: 30, fontWeight: FontWeight.bold)),
          Text(subtitulo, textAlign: TextAlign.justify, style: TextStyle(color: dorado, fontSize: 20, fontWeight: FontWeight.normal)),
        ],
      )
    );
  }

  Widget _crearTexto(String text) {
    return new Container(
      margin: new EdgeInsets.symmetric(vertical: 5, horizontal: 10),
      padding: EdgeInsets.all(8.0),
      child: new Container(
        child: Text(
          text,
          textAlign: TextAlign.justify,
          style: new TextStyle(fontWeight: FontWeight.normal, color: dorado, fontSize: 17)
        ),
      ),
    );
  }

  Widget _crearTags(List<String> tags) {
    List<Widget> widgets = new List<Widget>();
    tags.forEach((x)=>widgets.add(_tag(x)));
    return Container(
      margin: new EdgeInsets.symmetric(vertical: 5, horizontal: 15),
      child: Row(
        children: widgets,
      ),
    );
  }
        
  Widget _crearSkins(String name, List<String> tags) {
    List<Widget> widgets = new List<Widget>();
    tags.forEach((x)=>widgets.add(_cardSkin(name, x)));
    return Container(
      height: 175,
      margin: new EdgeInsets.symmetric(vertical: 5, horizontal: 15),
      child: ListView(
        scrollDirection: Axis.horizontal,
        controller: new PageController(viewportFraction: 0.3),
        children: widgets,
      ),
    );
  }
  Widget _cardSkin(String name, String id){
    return GestureDetector(
      child: Container(
        width: 95,
        margin: EdgeInsets.symmetric(horizontal: 2),
        decoration: new BoxDecoration(
          color: fondotrans,
          shape: BoxShape.rectangle,
          border: Border.all(color: dorado, width: 2),
          image: DecorationImage(image: NetworkImage("http://ddragon.leagueoflegends.com/cdn/img/champion/loading/$name"+"_$id.jpg"),fit: BoxFit.contain),
        ),
        padding: EdgeInsets.all(8.0),
      ),
      onTap:() => setState(() {
        fondoCampeon ="http://ddragon.leagueoflegends.com/cdn/img/champion/splash/$name"+"_$id.jpg";
      }),
    );
  }

  Widget _tag(String text){
    return Container(
      margin: EdgeInsets.symmetric(horizontal: 2),
      decoration: new BoxDecoration(
        color: fondotrans,
        shape: BoxShape.rectangle,
        border: Border.all(color: dorado, width: 2)
      ),
      padding: EdgeInsets.all(8.0),
      child: Center(
        child: Text(
          text,
          textAlign: TextAlign.justify,
          style: new TextStyle(
            fontWeight: FontWeight.bold,
            color: dorado,
            fontSize: 15
          )
        ),
      ),
    );
  }

  Widget _cargando(){
    return Center(child: (CircularProgressIndicator()));
  }

  Widget _divider(){
    return Divider(
      height: 10,
      indent: 15,
      endIndent: 15,
      color: dorado,
      thickness: 2,
    );
  }
}