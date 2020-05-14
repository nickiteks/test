package subd.entity;

import javax.persistence.*;

@Entity
public class Product {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;

    private String nomination;

    private Integer count;

    private Integer cost;

    @ManyToOne
    private  Provider provider;

    @Override
    public String toString(){
        return "Product {\n" +
                "id =" + id + ",\n" +
                "nomination=" + nomination + ",\n" +
                "count=" + count + ",\n" +
                "cost=" + cost + ",\n" +
                "}" + "\n";
    }
}
