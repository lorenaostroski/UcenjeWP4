import { HttpService } from "./HttpService"


async function get(){
    await HttpService.get('/Smjer')
    .then((odgovor)=>{
        console.log(odgovor);
    })

}

export default{
    get
}