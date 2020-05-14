package subd.entity;

import javax.persistence.*;
import java.util.List;

@Entity
public class Client {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;

    private String name;

    private String surname;

    private String patronymic;

    @OneToMany
    private List<Orders> orders;

    public String toString() {
        return "Client {\n" +
                "id =" + id + ",\n" +
                "name=" + name + ",\n" +
                "surname=" + surname + ",\n" +
                "patronymic=" + patronymic + ",\n" +
                "}" + "\n";
    }
}
