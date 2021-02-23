import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { disableDebugTools } from '@angular/platform-browser';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Medico } from '../models/Medico';
import { MedicoService } from '../services/Medico.service';

@Component({
  selector: 'app-medico',
  templateUrl: './medico.component.html',
  styleUrls: ['./medico.component.css']
})
export class MedicoComponent implements OnInit {

 titleMedico = 'Médicos';

 public selectedMedico: Medico;
 public medicoForm: FormGroup;


 public medicos: Medico[];
  

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

  loadMedico(){
    this.medicoService.getAll().subscribe(
      (medicos: Medico[]) => {
        this.medicos = medicos;
      },
      (error: any) => {
        console.log(error);
      }
    );
  }

  constructor(private fb: FormBuilder, private modalService:BsModalService, 
              private medicoService: MedicoService) { 
    this.createForm();
  }

  ngOnInit(): void {
    this.loadMedico();

  }

}




