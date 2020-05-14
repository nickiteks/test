package subd;

import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Sort;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.context.event.ApplicationReadyEvent;
import org.springframework.context.event.EventListener;
import subd.entity.Worker;
import subd.repository.*;

import java.sql.Date;


@SpringBootApplication
public class Application {

    private ClientRepository clientRepository;

    private OrdersRepository ordersRepository;

    private ProductRepository productRepository;

    private ProviderRepository providerRepository;

    private WerehouseRepository werehouseRepository;

    private WorkerRepository workerRepository;

    @Autowired
    public Application(ClientRepository clientRepository,
                       OrdersRepository ordersRepository,
                       ProductRepository productRepository,
                       ProviderRepository providerRepository,
                       WerehouseRepository werehouseRepository,
                       WorkerRepository workerRepository) {
        this.clientRepository = clientRepository;
        this.ordersRepository = ordersRepository;
        this.productRepository = productRepository;
        this.providerRepository = providerRepository;
        this.werehouseRepository = werehouseRepository;
        this.workerRepository = workerRepository;
    }

    public static void main(String[] args){

        SpringApplication.run(Application.class,args);
    }
    @EventListener(ApplicationReadyEvent.class)
    public void onStart() {

        System.out.println(productRepository.getAllByNominationEquals("Мебель"));
        System.out.println(werehouseRepository.getAllByDateBetween(new Date(1526101829L) ,new Date(System.currentTimeMillis())));
        readWorkers();
        readClients();
    }

    private void createWorker(int id , String post, Integer experience,String name , String surname ,String patronymic) {
        Worker worker = new Worker();

        workerRepository.save(worker);

    }

    private void delWorker(){
        workerRepository.deleteById(302);
    }

    private  void readWorkers() {
        workerRepository.findAll(PageRequest.of(0, 3, Sort.Direction.DESC, "name"))
                .toList()
                .forEach(System.out::println);
    }

    private void updateWorkers() {
        Worker worker = new Worker();
        workerRepository.save(worker);
    }

    private  void readClients() {
        clientRepository.findAll(PageRequest.of(0, 3, Sort.Direction.DESC, "surname"))
                .toList()
                .forEach(System.out::println);
    }

    private  void readOrders() {
        ordersRepository.findAll(PageRequest.of(0, 3, Sort.Direction.DESC, "surname"))
                .toList()
                .forEach(System.out::println);
    }

    private  void readProducts() {
        productRepository.findAll(PageRequest.of(0, 3, Sort.Direction.DESC, "surname"))
                .toList()
                .forEach(System.out::println);
    }

    private  void readProviders() {
        providerRepository.findAll(PageRequest.of(0, 3, Sort.Direction.DESC, "surname"))
                .toList()
                .forEach(System.out::println);
    }

    private  void readWherehouses() {
        werehouseRepository.findAll(PageRequest.of(0, 3, Sort.Direction.DESC, "surname"))
                .toList()
                .forEach(System.out::println);
    }
}
