/*class Team{
  final int id;
  final String name;
  final String password;
  Team(this.id, this.name, this.password);
}*/

import 'dart:convert';

class Team{
  final int id;
  final String name;
  final String password;
  Team({this.id, this.name, this.password});
  factory Team.fromJson(Map<String, dynamic> json){
    return Team(
      id: json["Id"],
      name: json["Name"],
      password: json["Password"],
    );
  }
}