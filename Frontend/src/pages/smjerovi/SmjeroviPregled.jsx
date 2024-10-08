import { Container, Table } from "react-bootstrap";
import SmjerService from "../../services/SmjerService";
import { useEffect } from "react";


export default function SmjeroviPregled(){

    async function dohvatiSmjerove() {

        await SmjerService.get();
    }

    useEffect(()=>{
        dohvatiSmjerove();
    },[]);



    return(

        <Container>
            <Table striped bordered hover responsive>
                <thead>
                   <tr>
                        <th>Naziv</th> 
                        <th>Trajanje</th>
                        <th>Cijena</th>
                        <th>Izvodi se od</th>
                        <th>Vaučer</th>
                        <th>Akcija</th>
                   </tr>
              </thead>
            </Table>
        </Container>
    )


}