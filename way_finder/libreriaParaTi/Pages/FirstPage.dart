// import 'dart:developer';
// import 'dart:ui' as prefix0;
import 'dart:ui';
import 'dart:async';
import 'dart:convert';
import 'package:flutter/material.dart';

import '../Model/Champion.dart';

import 'package:http/http.dart' as http;

class FirstPage extends StatelessWidget {
  
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: PageView(
        scrollDirection: Axis.vertical,
        children: <Widget>[
          _pagina1(),
          _pagina2(context),
        ],
      )
    );
  }

  //PAGES

  Widget _pagina1() {
    return Stack(
      children: <Widget>[
        _imagenFondo(),
      ],
    );
  }

  Widget _listView2(AsyncSnapshot snapshot, BuildContext context){
    return GridView.builder(
      gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(crossAxisCount: 2, childAspectRatio: (2/3.4),),
      itemCount: snapshot.data.length,
      itemBuilder: (BuildContext context, int index){
        return GestureDetector(
          child: _carta(snapshot, index, context),  
        );
      }
    );
  }

  Widget _pagina2(BuildContext context) {
    return Container(
      width: double.infinity,
      height: double.infinity,
      decoration: _boxDecorationImg("assets/backgroundImg_2.jpg"),
      child: FutureBuilder(
        future: getData(),
        builder: (BuildContext context, AsyncSnapshot snapshot){
          if(snapshot.data == null){
            return _cargando();
          }
          return _listView2(snapshot, context);
        },
      ),
    );
  }

  //FUNCIONES

  Future<List<ChampionCard>> getData() async {

    List<ChampionCard> champions = [];

    http.Response response_1 = await http.get("http://ddragon.leagueoflegends.com/cdn/9.22.1/data/en_US/champion.json");
    Map<String, dynamic> data = json.decode(response_1.body)["data"];
    
    for (var item in data.keys) {
      ChampionCard champcard = new ChampionCard(item, data[item]["title"], "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/$item"+"_0.jpg");
      champions.add(champcard);
    }
    
    return champions;
  }

  //WIDGETS EXTRA

  Widget _carta(AsyncSnapshot snapshot, int index, BuildContext context){
    return GestureDetector(
      child: Container(
        margin: EdgeInsets.symmetric(horizontal: 20, vertical: 25),
        decoration: BoxDecoration(
          image: DecorationImage(image: NetworkImage(snapshot.data[index].img)),
          color: Color.fromRGBO(31, 44, 61, 0.7),
          border: Border.all(color: Color.fromRGBO(187, 146, 95, 1), width: 3)
        ),
        child:_textoCarta(snapshot, index)
      ),
      onTap: ()=> Navigator.pushNamed(context, 'detail', arguments: snapshot.data[index].name),
    );
  }

  Widget _textoCarta(AsyncSnapshot snapshot, int index){
    return Container(
      margin: new EdgeInsets.only(top: 210),
      color: Color.fromRGBO(31, 44, 61, 0.7),
      child: Center(
        child: Column(
          children: <Widget>[
            _texto(snapshot.data[index].name, 22),
            _texto(snapshot.data[index].title, 10)
          ],
        )
      ),
    );
  }
  Widget _texto(String text, double fontSize){
    return Text(
      text,
      style: TextStyle(
        color: Color.fromRGBO(187, 146, 95, 1),
        fontSize: fontSize,
      ),
    );
  }

  Widget _imagenFondo() {
    return Container(
      width: double.infinity,
      height: double.infinity,
      decoration: _boxDecorationImg("assets/backgroundImg_1.jpg"),
      child: _containerRowDown(),
    );
  }

  BoxDecoration _boxDecorationImg(String assetRoute){
    return BoxDecoration(
        color: Color.fromRGBO(31, 44, 61, 0.7),
        image: DecorationImage(
          image: AssetImage(assetRoute),
          fit: BoxFit.cover,
        )
      );
  }

  Widget _cargando(){
    return Center(child: (CircularProgressIndicator()));
  }

  Widget _containerRowDown(){
    return Container(
      margin: new EdgeInsets.only(top: 575),
      decoration: BoxDecoration(
        gradient: LinearGradient(
          begin: Alignment.topCenter,
          end: Alignment.bottomCenter,
          colors: [Color.fromRGBO(37, 53, 78, 1), Color.fromRGBO(31, 44, 61, 1), Color.fromRGBO(13, 18, 24, 1)]
        ),
        border: Border(
          top: BorderSide(color: Color.fromRGBO(187, 146, 95, 1), width: 2),
          bottom: BorderSide(color: Color.fromRGBO(187, 146, 95, 1), width: 0.2)
        )
      ),
      child: Center(
        child: Icon(Icons.keyboard_arrow_down, color: Color.fromRGBO(187, 146, 95, 1), size: 50),
      ),
    );
  }
}