import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:leagueoflegends/Pages/DetailPage.dart';
import 'package:leagueoflegends/Pages/FirstPage.dart';

void main() => runApp(MyApp());
 
class MyApp extends StatelessWidget {
  
  @override
  Widget build(BuildContext context) {

    SystemChrome.setSystemUIOverlayStyle( SystemUiOverlayStyle.light.copyWith(
      statusBarColor: Colors.transparent
    ));

    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Diseños',
      initialRoute: 'first',
      routes: {
        'first'  : (BuildContext context) => FirstPage(),
        'detail' : (BuildContext context) => DetailPage(),
      },
    );
  }
}