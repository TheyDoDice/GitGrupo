import 'dart:async';
import 'package:flutter/material.dart';
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
    Navigator.of(context).pushReplacementNamed('Login');
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
          ),
        ],
      ),
    );
  }
}