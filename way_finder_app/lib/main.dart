import 'package:flutter/material.dart';
import 'pages/classPages.dart';

void main() {
  runApp(new MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return new MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Way Finder',
      initialRoute: 'Splash',
      routes: <String, WidgetBuilder>{
        'Splash': (BuildContext context) => new SplashScreen(),
        'Login': (BuildContext context) => new Login(),
        'ListaConcursos': (BuildContext context) => new ListaConcursos(),
        'Pistas': (BuildContext context) => new Pistas(),
        'Registrar': (BuildContext context) => new Registrar(),
        'Home': (BuildContext context) => new Home(),
        'EscogerCiudad': (BuildContext context) => new EscogerCiudad(),
        'EscogerLocalizacion': (BuildContext context) => new EscogerLocalizacion()
      } 
    );
  }
}

