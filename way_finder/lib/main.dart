import 'dart:async';
import 'package:flutter/material.dart';
import 'package:way_finder/pages/login_signup_page.dart';
import 'package:way_finder/services/authentication.dart';
import 'package:way_finder/pages/root_page.dart';

void main() {
  runApp(new MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return new MaterialApp(
       // title: 'Flutter login demo',
      color: Colors.white,
      debugShowCheckedModeBanner: false,
      theme: new ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: SplashScreen(),
      routes: <String, WidgetBuilder>{
        '/Login': (BuildContext context) => new Login()//new RootPage(auth: new Auth())
      } 
    );
  }
}

class SplashScreen extends StatefulWidget {
  @override
  _SplashScreenState createState() => _SplashScreenState();
}


class _SplashScreenState extends State<SplashScreen> {
  startTime() async {
    var _duration = new Duration(seconds: 3);
    return new Timer(_duration, navigationPage);
  }

   @override
  void initState() {
    super.initState();
    startTime();
  }

  void navigationPage() {
    Navigator.of(context).pushReplacementNamed('/Login');
  }

  @override
  Widget build(BuildContext context){
    return Container(
      color: Colors.blueGrey,
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          Container(
            padding: EdgeInsets.all(20),
            child: Image.asset(
              'assets/logo.png',
              height: 410,
              fit: BoxFit.fitHeight,
            ),
            /*  decoration: BoxDecoration(
                borderRadius: BorderRadius.all(Radius.circular(90)),
                color: Colors.white),*/
          ),
          /*Container(
            padding: EdgeInsets.all(20),
            child: Image.asset(
              'images/loading.gif',
              height: 70,
            ),
          )*/
        ],
      ),
    );
  }
}
