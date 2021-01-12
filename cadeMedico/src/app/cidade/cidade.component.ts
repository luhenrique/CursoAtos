import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Cidade } from '../models/Cidade';

@Component({
  selector: 'app-cidade',
  templateUrl: './cidade.component.html',
  styleUrls: ['./cidade.component.css']
})
export class CidadeComponent implements OnInit {

  titleCidade = 'Cidades';
  public selectedCidade: Cidade;
  public cidadeForm: FormGroup;

  public cidades = [
  {id: '1', nome:'Apucarana', estado: 'PR'},
  {id: '2', nome:'Londrina', estado: 'PR'},
  {id: '3', nome:'Maringá', estado: 'PR'},
  {id: '4', nome:'São Paulo', estado: 'SP'},
  {id: '5', nome:'Rio de Janeiro', estado: 'RJ'},
  ]


  createForm(){
    this.cidadeForm = this.fb.group({
      nome: ['', Validators.required],
      estado: ['', Validators.required]
    })
  }

  selectCidade(cidade: Cidade){
    this.selectedCidade = cidade;
    this.cidadeForm.patchValue(cidade);
  }

  submit(){
    console.log(this.cidadeForm.value);
  }

  back(){
    this.selectedCidade = null;
  }

  constructor(private fb:FormBuilder) { 
    this.createForm();
  }

  ngOnInit(): void {
  }

}
