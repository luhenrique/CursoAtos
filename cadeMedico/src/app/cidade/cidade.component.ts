import { Component, OnInit } from '@angular/core';
import { Cidade } from '../models/Cidade';

@Component({
  selector: 'app-cidade',
  templateUrl: './cidade.component.html',
  styleUrls: ['./cidade.component.css']
})
export class CidadeComponent implements OnInit {

  titleCidade = 'Cidades';
  public selectedCidade: Cidade;

  public cidades = [
  {id: '1', nome:'Apucarana', estado: 'PR'},
  {id: '2', nome:'Londrina', estado: 'PR'},
  {id: '3', nome:'Maringá', estado: 'PR'},
  {id: '4', nome:'São Paulo', estado: 'SP'},
  {id: '5', nome:'Rio de Janeiro', estado: 'RJ'},
  ]

  selectCidade(cidade: Cidade){
    this.selectedCidade = cidade;
  }

  back(){
    this.selectedCidade = null;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
