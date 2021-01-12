import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { disableDebugTools } from '@angular/platform-browser';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Medico } from '../models/Medico';

@Component({
  selector: 'app-medico',
  templateUrl: './medico.component.html',
  styleUrls: ['./medico.component.css']
})
export class MedicoComponent implements OnInit {

 titleMedico = 'Médicos';

 public selectedMedico: Medico;
 public medicoForm: FormGroup;


 public medicos = [
   {id:'1',nome:'Luiz'   , especialidade:'Cardiologista', crm:'4325325', telefone:'646346343'},
   {id:'2',nome:'João'   , especialidade:'Clinico Geral', crm:'4325325', telefone:'646346343'},
   {id:'3',nome:'Cloves' , especialidade:'Psiquiatra', crm:'4325325', telefone:'646346343'}, 
   {id:'4',nome:'Cleytin', especialidade:'Podologista', crm:'4325325', telefone:'646346343'}, 
   {id:'5',nome:'Chico'  , especialidade:'Otorrinolaringologista', crm:'4325325', telefone:'646346343'}
  ]
  

  public modalRef: BsModalRef;

  openModal(template: TemplateRef<any>){
    this.modalRef = this.modalService.show(template);
  }


  createForm(){
    this.medicoForm = this.fb.group({
        nome: ['', Validators.required],
        especialidade: ['', Validators.required],
        crm: ['', Validators.required],
        telefone: ['', Validators.required]
    });
  }

  selectMedico(medico: Medico){
    this.selectedMedico = medico;
    this.medicoForm.patchValue(medico)
  }

  back(){
    this.selectedMedico = null;
  }

  submit(){
    console.log(this.medicoForm.value);
  }

  constructor(private fb: FormBuilder, private modalService:BsModalService) { 
    this.createForm();
  }

  ngOnInit(): void {
  }

}




