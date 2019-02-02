var cHello =
{
    bindings:{
        firstlastname: '@',
        competence: '='
    },
    template: `<div class="alert alert-dismissible fade show alert-success" role="alert">
                    Witaj <b>{{$ctrl.firstlastname}}</b> z {{$ctrl.user.Company}}
                    specjalisto od <i>{{$ctrl.competence.Name}} </i>
                    <button type="button" class="close" data-dismiss="alert">
                        &times;</span>
                    </button>
              </div>`,
    controller: function(){
        this.user = {Company: 'WSB'};
    }
};