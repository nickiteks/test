package subd.entity;

import javax.persistence.*;
import java.util.List;

@Entity
public class Provider {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;

    private String inn;

    private String address;

    private String name;

    private String surname;

    private String patronymic;
    @OneToMany
    private List<Product> products;

    @Override
    public String toString() {
        return "Provider {\n" +
                "id =" + id + ",\n" +
                "inn =" + inn + ",\n" +
                "address=" + address + ",\n" +
                "name=" + name + ",\n" +
                "surname=" + surname + ",\n" +
                "patronymic=" + patronymic + ",\n" +
                "}" + "\n";
    }
}
