package subd.entity;

import javax.persistence.*;
import java.sql.Date;
import java.sql.Timestamp;
import java.util.List;

@Entity
public class Werehouse {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;

    private Date date;

    @ManyToOne
    private Product product;

    @ManyToOne
    private Worker worker;

    @OneToMany
    private List<Orders> orders;

    @Override
    public String toString() {
        return "Werehouse {\n" +
                "id =" + id + ",\n" +
                "date=" + date + ",\n" +
                "product=" + product + ",\n" +
                "}" + "\n";
    }
}
